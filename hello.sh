# this is a comment test
# this is a comment test again
echo Hello
Echo World

msg="hello world"
echo $msg

echo what is your name?
read userInput
echo "Hello $userInput, Welcome to Programming!"


# Control Flow
# Types of loops
# For Loop - They will repeat something a set number of times
for var in 1 2 3 4 5
do
	echo $var
	echo This variable currently holds: $var
done

for i in {1..10..1} #starting number.. end number..incrementing number
do
	echo $i
done


# While loops - they will repeat something until the condition isn't satisfied anymore
condition="true"

while [ "$condition" != "false" ]
do 
	echo "do you want to repeat? (true or false)"
	read condition
	echo "you typed: $condition"
done
