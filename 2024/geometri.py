import math

def main():
    while True:
        print("\033c", end="")  # This clears the console
        print("Choose a geometric shape to calculate the area:")
        print("1. Triangle")
        print("2. Rectangle")
        print("3. Circle")
        print("4. Exit")
        choice = input()

        if choice == "1":
            calculate_triangle_area()
        elif choice == "2":
            calculate_rectangle_area()
        elif choice == "3":
            calculate_circle_area()
        elif choice == "4":
            return
        else:
            print("Invalid choice. Please enter a number between 1 and 4.")

        print("Do you want to calculate another area? (y/n)")
        if input().lower() != "y":
            break

def calculate_triangle_area():
    base_triangle = float(input("Enter the base of the triangle: "))
    height = float(input("Enter the height of the triangle: "))

    area = triangle_area(base_triangle, height)
    print(f"The area of the triangle is: {area}")

def calculate_rectangle_area():
    length = float(input("Enter the length of the rectangle: "))
    width = float(input("Enter the width of the rectangle: "))

    area = rectangle_area(length, width)
    print(f"The area of the rectangle is: {area}")

def calculate_circle_area():
    radius = float(input("Enter the radius of the circle: "))

    area = circle_area(radius)
    print(f"The area of the circle is: {area}")

def triangle_area(base_triangle, height):
    return 0.5 * base_triangle * height

def rectangle_area(length, width):
    return length * width

def circle_area(radius):
    return math.pi * radius ** 2

if __name__ == "__main__":
    main()
