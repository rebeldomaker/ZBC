import datetime

def main():
    while True:
        print("Menu:")
        print("1) Vurdering af tal")
        print("2) Udskriv liste af lige tal")
        print("3) Alder")
        print("4) Afslut")
        choice = input("Vælg en mulighed: ")

        if choice == "1":
            evaluate_numbers()
        elif choice == "2":
            print_even_numbers()
        elif choice == "3":
            calculate_age()
        elif choice == "4":
            break
        else:
            print("Ugyldigt valg. Prøv igen.")

def evaluate_numbers():
    print("Indtast 4 heltal:")
    numbers = []
    for i in range(4):
        num = int(input(f"Tal {i + 1}: "))
        numbers.append(num)

    even_count = sum(1 for num in numbers if num % 2 == 0)
    odd_count = sum(1 for num in numbers if num % 2 != 0)
    greater_than_100_count = sum(1 for num in numbers if num > 100)
    negative_count = sum(1 for num in numbers if num < 0)

    print(f"Antal lige tal: {even_count}")
    print(f"Antal ulige tal: {odd_count}")
    print(f"Antal tal større end 100: {greater_than_100_count}")
    print(f"Antal negative tal: {negative_count}")

def print_even_numbers():
    print("Indtast to heltal:")
    num1 = int(input("Første tal: "))
    num2 = int(input("Andet tal: "))

    min_num = min(num1, num2)
    max_num = max(num1, num2)

    print("Lige tal mellem de to tal:")
    for i in range(min_num, max_num + 1):
        if i % 2 == 0:
            print(i)

    division_count = max_num // min_num
    print(f"Det mindste tal går op i det største {division_count} gange.")

def calculate_age():
    print("Indtast din fødselsdato:")
    year = int(input("År: "))
    month = int(input("Måned: "))
    day = int(input("Dag: "))

    birth_date = datetime.date(year, month, day)
    current_date = datetime.date.today()

    age = current_date.year - birth_date.year
    if current_date < birth_date.replace(year=current_date.year):
        age -= 1

    print(f"Din alder er: {age} år.")

if __name__ == "__main__":
    main()
