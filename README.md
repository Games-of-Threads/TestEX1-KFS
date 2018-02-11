# TestEX1-KFS
>by Kristian Flejsborg Sørensen (cph-kf96)

this is the handin for the first test couse exercise, it's specification's can be read at the two last slide in [this](https://github.com/datsoftlyngby/soft2018spring-test-teaching-material/blob/master/slides/IntroductionTest.pdf) presentation.

## Step 1

there are 3 different scenarios of succes, and multiple scenarios of failure, to reduce the amount of failure scenarios I'll only make failure scenarios in relation to the 3 succes scenarios.

**Test Case:** Scalene   
**input:** 3 different integers   
**expected output:** triangle is a scalene as all sides are not relative in length to eachother.   
**output:** triangle is a scalene as all sides are not relative in length to eachother.   
**test case succes:** yes   

**Test Case:** Scalene   
**input:** 3 different integers   
**expected output:** triangle is a scalene as all sides are not relative in length to eachother.   
**output:** triangle is a equilateral as all sides are relative in length to eachother.   
**test case succes:** no   

**Test Case:** isosceles   
**input:** 2 relative integers and 1 integer that's different   
**expected output:** triangle is a isosceles as 2 sides are relative in length to eachother, yet the last is not.   
**output:** triangle is a isosceles as 2 sides are relative in length to eachother, yet the last is not.   
**test case succes:** yes   

**Test Case:** isosceles   
**input:** 2 relative integers and 1 integer that's different   
**expected output:** triangle is a isosceles as 2 sides are relative in length to eachother, yet the last is not.   
**output:** triangle is a isosceles as 1 side are relative in length to itself, yet the 2 others aren't.   
**test case succes:** no

**Test Case:** equilateral   
**input:** 3 relative integers   
**expected output:** triangle is a equilateral as all sides are relative in length to eachother.   
**output:** triangle is a equilateral as all sides are relative in length to eachother.   
**test case succes:** yes   

**Test Case:** equilateral   
**input:** 3 relative integers   
**expected output:** triangle is a equilateral as all sides are relative in length to eachother.   
**output:** triangle is a scalene as all sides are not relative in length to eachother.   
**test case succes:** no   

## Step 2

See Release folder for program.
