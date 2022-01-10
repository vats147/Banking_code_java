#!/bin/bash

read -p "Hii Harshal!!"

date "+It's %r"

h=$(date +"%H")

if [ "$h" -ge "6" -a "$h" -le "12" ]
then
echo "Good Morning"
elif [ "$h" -ge "12" -a "$h" -le "16" ]
then
echo "Good Afternoon"
elif [ "$h" -ge "16" -a "$h" -le "20" ]
then
echo "Good Evening"
else
echo "Good Night"
fi
