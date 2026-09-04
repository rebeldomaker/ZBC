import os

def main():
    while True:
        os.system('cls' if os.name == 'nt' else 'clear')
        print("Choose an option:")
        print("1) Calculate average manually")
        print("2) Calculate average from file (extra)")
        print("3) Exit")
        choice = input()

        if choice == "1":
            calculate_average_manual()
        elif choice == "2":
            calculate_average_from_file()
        elif choice == "3":
            return
        else:
            print("Invalid choice. Please try again.")

        if input("Do you want to calculate the average of another series of numbers? (y/n)").lower() != 'y':
            break

def calculate_average_manual():
    numbers = []
    print("Enter values (type 'q' to finish):")

    while True:
        input_value = input()
        if input_value.lower() == 'q':
            break

        try:
            value = float(input_value)
            numbers.append(value)
        except ValueError:
            print("Invalid input. Please try again.")

    if numbers:
        average = sum(numbers) / len(numbers)
        print(f"The average is: {average}")
    else:
        print("No values were entered.")

def calculate_average_from_file():
    file_name = input("Enter the file name (including extension):")

    try:
        with open(file_name, 'r') as file:
            lines = file.readlines()
            numbers = []

            for line in lines:
                try:
                    value = float(line.strip())
                    numbers.append(value)
                except ValueError:
                    print(f"Invalid value in file: {line.strip()}")

            if numbers:
                average = sum(numbers) / len(numbers)
                print(f"The average is: {average}")
            else:
                print("No valid values were found in the file.")
    except Exception as e:
        print(f"Could not read the file: {e}")

if __name__ == "__main__":
    main()
