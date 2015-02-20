<?php

class Utility
{
    /**
     * Takes the submit date and turnaround time as an input
     * and returns the date and time when the issue is to be resolved
     *
     * @param string $submitDate Submit date in Y-m-d H:i format
     * @param int $turnaroundTime Turnaround time (number of hours)
     *
     * @return string Due date and time in Y-m-d H:i format
     */
    public static function CalculateDueDate($submitDate, $turnaroundTime)
    {
        $submitTime = strtotime($submitDate);

        $dayOfWeek = date('N', $submitTime);

        $submitHours = date('H', $submitTime) - 9;
        $submitMins = date('i', $submitTime);

        $alteredSubmitTime = ($dayOfWeek-1)*8 + $submitHours + $submitMins / 60;

        $alteredDue = $alteredSubmitTime + $turnaroundTime;

        $weeks = floor($alteredDue / 40);

        $alteredOneWeek = $alteredDue - $weeks * 40;

        if($weeks) {
            $onCurrentWeek = 40 - $alteredSubmitTime;
            $onNextWeek = $alteredOneWeek;
            $diff = $onCurrentWeek + $onNextWeek + ($weeks-1)*40;
            $d = floor($onCurrentWeek / 8) + floor($onNextWeek / 8) + 1 + ($weeks-1)*5;
        } else {
            $diff = $alteredOneWeek - $alteredSubmitTime;
            $d = floor($alteredOneWeek / 8) - floor($alteredSubmitTime / 8);
        }

        $h = $diff - $d * 8;
        $hours = $d * 24 + $h + $weeks * 48;

        return date('Y-m-d H:i', $submitTime + $hours*60*60);
    }
}
