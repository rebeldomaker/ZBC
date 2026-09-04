def main():
    while True:
        print("Choose:")
        print("1. Tasks with While Loops")
        print("2. Tasks with For Loops")
        print("3. Tasks with Switch")
        print("4. Tasks with If-Else")
        print("5. Tasks with Arrays")
        print("6. Exit!!? (ノಠ益ಠ)ノ彡┻━┻")
        choice = input()

        if choice == "1":
            while_loop_tasks()
        elif choice == "2":
            for_loop_tasks()
        elif choice == "3":
            switch_tasks()
        elif choice == "4":
            if_else_tasks()
        elif choice == "5":
            array_tasks()
        elif choice == "6":
            break
        else:
            print("Invalid choice. Please enter a number between 1 and 6.")

def while_loop_tasks():
    while True:
        print("Choose a while loop task:")
        print("1. Calculator (with switch)")
        print("2. Guess a number, Tamagotchi style!")
        print("3. Return to main menu (; •_•)")
        choice = input()

        if choice == "1":
            calculator_with_while()
        elif choice == "2":
            guess_number()
        elif choice == "3":
            return
        else:
            print("Invalid choice. Please enter a number between 1 and 3.")

def for_loop_tasks():
    while True:
        print("Choose a for loop task:")
        print("1. Print all integers between 1 and n")
        print("2. Print the n times table")
        print("3. Print the full multiplication table")
        print("4. Calculate the average of n numbers")
        print("5. Return to main menu ( ㄒoㄒ)")
        choice = input()

        if choice == "1":
            print_integers()
        elif choice == "2":
            print_times_table()
        elif choice == "3":
            print_full_multiplication_table()
        elif choice == "4":
            calculate_average()
        elif choice == "5":
            return
        else:
            print("Invalid choice. Please enter a number between 1 and 5.")

def switch_tasks():
    while True:
        print("Choose a switch task:")
        print("1. Print day of the week")
        print("2. Print number of days in a month")
        print("3. Simple calculator")
        print("4. Return to main menu? ( ╥ω╥ )")
        choice = input()

        if choice == "1":
            print_day_of_week()
        elif choice == "2":
            print_days_in_month()
        elif choice == "3":
            simple_calculator()
        elif choice == "4":
            return
        else:
            print("Invalid choice. Please enter a number between 1 and 4.")

def if_else_tasks():
    while True:
        print("Choose an if-else task:")
        print("1. Find the largest number")
        print("2. Check divisibility by 3 and 5")
        print("3. Print number of days in a month")
        print("4. Price calculator")
        print("5. Return to main menu ૮( ͡° ᴥ ͡°)ა !!")
        choice = input()

        if choice == "1":
            find_largest_number()
        elif choice == "2":
            check_divisibility()
        elif choice == "3":
            if_else_days_in_month()
        elif choice == "4":
            price_calculator()
        elif choice == "5":
            return
        else:
            print("Invalid choice. Please enter a number between 1 and 5.")

def array_tasks():
    while True:
        print("Choose an array task:")
        print("1. Basic array usage")
        print("2. Print negative values in array")
        print("3. Print sum of array values")
        print("4. Print largest and smallest value in array")
        print("5. Sort and print array values")
        print("6. Return to main menu (; ˃o˂)")
        choice = input()

        if choice == "1":
            basic_array_usage()
        elif choice == "2":
            print_negative_values()
        elif choice == "3":
            print_sum_of_array()
        elif choice == "4":
            print_largest_and_smallest()
        elif choice == "5":
            sort_and_print_array()
        elif choice == "6":
            return
        else:
            print("Invalid choice. Please enter a number between 1 and 6.")

def calculator_with_while():
    while True:
        num1 = float(input("Enter first number:"))
        op = input("Enter operator (+, -, *, /):")
        num2 = float(input("Enter second number:"))

        result = 0
        valid_operation = True

        if op == "+":
            result = num1 + num2
        elif op == "-":
            result = num1 - num2
        elif op == "*":
            result = num1 * num2
        elif op == "/":
            if num2 != 0:
                result = num1 / num2
            else:
                print("Cannot divide by zero.")
                valid_operation = False
        else:
            print("Invalid operator.")
            valid_operation = False

        if valid_operation:
            print("Result: " + str(result))

        if input("Do you want to perform another calculation? (y/n)").lower() != "y":
            break

def guess_number():
    import random
    lower = int(input("Enter the lower bound:"))
    upper = int(input("Enter the upper bound:"))
    target = random.randint(lower, upper)
    attempts = 0
    guess = 0

    while guess != target:
        guess = int(input("Guess the number:"))
        attempts += 1

        if guess < target:
            print("Too low! (˃ᆺ˂)")
        elif guess > target:
            print("Too high!  υ´• ﻌ •`υ")
        else:
            print(f"Correct! You guessed the number in {attempts} attempts.")

def print_integers():
    n = int(input("Enter a number (n):"))

    print("All integers from 1 to " + str(n) + ":")
    for i in range(1, n + 1):
        print(i)

    print("All integers from " + str(n) + " to 1:")
    for i in range(n, 0, -1):
        print(i)

def print_times_table():
    n = int(input("Enter a number (n) for the times table:"))

    print("The " + str(n) + " times table:")
    for i in range(1, 11):
        print(n * i)

def print_full_multiplication_table():
    print("The full multiplication table (1 to 10):")
    for i in range(1, 11):
        for j in range(1, 11):
            print(f"{i * j:4}", end=" ")
        print()

def calculate_average():
    count = int(input("How many numbers do you want to enter for the average calculation?"))
    sum = 0

    for i in range(count):
        number = float(input(f"Enter number {i + 1}:"))
        sum += number

    average = sum / count
    print("The average is: " + str(average))

def print_day_of_week():
    day_number = int(input("Enter a number (1-7) for the day of the week:"))

    if day_number == 1:
        print("Monday")
    elif day_number == 2:
        print("Tuesday")
    elif day_number == 3:
        print("Wednesday")
    elif day_number == 4:
        print("Thursday")
    elif day_number == 5:
        print("Friday")
    elif day_number == 6:
        print("Saturday")
    elif day_number == 7:
        print("Sunday")
    else:
        print("Invalid input. Please enter a number between 1 and 7.")

def print_days_in_month():
    month_number = int(input("Enter a month number (1-12):"))

    if month_number in [1, 3, 5, 7, 8, 10, 12]:
        print("31 days")
    elif month_number in [4, 6, 9, 11]:
        print("30 days")
    elif month_number == 2:
        print("28 days")
    else:
        print("Invalid input. Please enter a number between 1 and 12.")

def simple_calculator():
    num1 = float(input("Enter first number:"))
    op = input("Enter operator (+, -, *, /):")
    num2 = float(input("Enter second number:"))

    result = 0
    valid_operation = True

    if op == "+":
        result = num1 + num2
    elif op == "-":
        result = num1 - num2
    elif op == "*":
        result = num1 * num2
    elif op == "/":
        if num2 != 0:
            result = num1 / num2
        else:
            print("Cannot divide by zero.")
            valid_operation = False
    else:
        print("Invalid operator.")
        valid_operation = False

    if valid_operation:
        print("Result: " + str(result))

def find_largest_number():
    num1 = int(input("Enter first number:"))
    num2 = int(input("Enter second number:"))
    num3 = int(input("Enter third number:"))

    if num1 >= num2 and num1 >= num3:
        print("The largest number is: " + str(num1))
    elif num2 >= num1 and num2 >= num3:
        print("The largest number is: " + str(num2))
    else:
        print("The largest number is: " + str(num3))

def check_divisibility():
    number = int(input("Enter a number:"))

    if number % 3 == 0 and number % 5 == 0:
        print("The number is divisible by both 3 and 5.")
    elif number % 3 == 0:
        print("The number is divisible by 3.")
    elif number % 5 == 0:
        print("The number is divisible by 5.")
    else:
        print("The number is not divisible by 3 or 5.")

    if number % 2 == 0:
        print("The number is even.")
    else:
        print("The number is odd.")

def if_else_days_in_month():
    month_number = int(input("Enter a month number (1-12):"))

    if month_number in [1, 3, 5, 7, 8, 10, 12]:
        print("31 days")
    elif month_number in [4, 6, 9, 11]:
        print("30 days")
    elif month_number == 2:
        print("28 days")
    else:
        print("Invalid input. Please enter a number between 1 and 12.")

def price_calculator():
    consumption = int(input("Enter electricity consumption in kWh:"))
    price = 0

    if consumption <= 1000:
        price = consumption * 1.25
    elif consumption <= 2000:
        price = 1000 * 1.25 + (consumption - 1000) * 1.75
    elif consumption <= 4000:
        price = 1000 * 1.25 + 1000 * 1.75 + (consumption - 2000) * 2.10
    else:
        price = 1000 * 1.25 + 1000 * 1.75 + 2000 * 2.10 + (consumption - 4000) * 2.75

    price *= 1.25  # Add 25% VAT
    print("Total price including VAT: " + str(price) + " kr.")

def basic_array_usage():
    numbers = [0] * 10
    print("Enter 10 integers:")

    for i in range(10):
        numbers[i] = int(input())

    print("The numbers you entered are:")
    for number in numbers:
        print(number)

    print("Using foreach loop:")
    for number in numbers:
        print(number)

def print_negative_values():
    numbers = [0] * 10
    print("Enter 10 integers:")

    for i in range(10):
        numbers[i] = int(input())

    print("The negative numbers you entered are:")
    for number in numbers:
        if number < 0:
            print(number)

def print_sum_of_array():
    numbers = [0] * 10
    print("Enter 10 integers:")

    for i in range(10):
        numbers[i] = int(input())

    sum = 0
    for number in numbers:
        sum += number

    print("The sum of the numbers is: " + str(sum))

def print_largest_and_smallest():
    numbers = [0] * 10
    print("Enter 10 integers:")

    for i in range(10):
        numbers[i] = int(input())

    largest = numbers[0]
    smallest = numbers[0]

    for number in numbers:
        if number > largest:
            largest = number
        if number < smallest:
            smallest = number

    print("The largest number is: " + str(largest))
    print("The smallest number is: " + str(smallest))

def sort_and_print_array():
    size = int(input("Enter the size of the array:"))
    numbers = [0] * size

    print("Enter " + str(size) + " integers:")
    for i in range(size):
        numbers[i] = int(input())

    numbers.sort()

    print("The sorted array is:")
    for number in numbers:
        print(number)

    if size > 1:
        print("The second highest value is: " + str(numbers[-2]))

def combine_arrays():
    size1 = int(input("Enter the size of the first array:"))
    array1 = [0] * size1
    print("Enter " + str(size1) + " integers for the first array:")
    for i in range(size1):
        array1[i] = int(input())

    size2 = int(input("Enter the size of the second array:"))
    array2 = [0] * size2
    print("Enter " + str(size2) + " integers for the second array:")
    for i in range(size2):
        array2[i] = int(input())

    combined_array = array1 + array2

    print("The combined array is:")
    for number in combined_array:
        print(number)

def search_in_string_array():
    texts = ["" for _ in range(10)]
    print("Enter 10 strings:")

    for i in range(10):
        texts[i] = input()

    search_string = input("Enter a string to search:")

    found = False
    for i in range(len(texts)):
        if texts[i] == search_string:
            print(f"Found '{search_string}' at position {i + 1}.")
            found = True
            break

    if not found:
        print(f"'{search_string}' not found in the array.")

if __name__ == "__main__":
    main()
