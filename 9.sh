#! /bin/bash

read x y z

if [ `$x -eq $y` -o `$z -eq $y` -o `$z -eq $x` ]
then
    echo "ISOSCELES"
elif [ `"$x" -eq "$y"`` -a `$y -eq $z` -a `$z -eq $x` ]
 
then
    echo "EQUILATERAL"
else
    echo "SCALENE"
    
fi
