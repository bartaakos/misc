<?php

include "Utility.php";

$tests = array(
    array('submitDate' => '2015-02-17 14:22', 'turnaround' => 16, 'expectedResult' => '2015-02-19 14:22'), // exact days within week
    array('submitDate' => '2015-02-17 14:22', 'turnaround' => 2, 'expectedResult' => '2015-02-17 16:22'), // within day
    array('submitDate' => '2015-02-17 14:22', 'turnaround' => 3, 'expectedResult' => '2015-02-18 09:22'), // step 1 day within week
    array('submitDate' => '2015-02-20 14:22', 'turnaround' => 3, 'expectedResult' => '2015-02-23 09:22'), // step 1 day to next week
    array('submitDate' => '2015-02-20 14:22', 'turnaround' => 11, 'expectedResult' => '2015-02-24 09:22'), // step 2 day to next week
    array('submitDate' => '2015-02-20 14:22', 'turnaround' => 27, 'expectedResult' => '2015-02-26 09:22'), // step 4 day to next week
    array('submitDate' => '2015-02-20 14:22', 'turnaround' => 35, 'expectedResult' => '2015-02-27 09:22'), // step 5 day to next week
    array('submitDate' => '2015-02-20 14:22', 'turnaround' => 51, 'expectedResult' => '2015-03-03 09:22'), // step to next month
    array('submitDate' => '2015-02-10 14:22', 'turnaround' => 80, 'expectedResult' => '2015-02-24 14:22'), // step to next month
);

foreach($tests as $test) {
    $result = Utility::CalculateDueDate($test['submitDate'], $test['turnaround']);
    var_dump(">>> " . $test['submitDate'] . " @ " . $test['turnaround'] . "H", $result, $result == $test['expectedResult'], "-------------------------");
}
