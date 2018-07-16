number1 = int(input("Give the first number: "))
powerOfArrows = int(input("Give the power of arrows: "))
number2 = int(input("Give the second number: "))

if powerOfArrows == 1:
    print("The result is ", pow(number1, number2))
elif powerOfArrows >= 1 and number2 == 0:
    print("The result is 1")
else:
    result = number1
    index = 1
    while index < number2:
        result = pow(number1, result)
        index += 1
    index = 2
    while index < powerOfArrows:
        result = pow(number1, result)
        index += 1
    print("The result is ", result)