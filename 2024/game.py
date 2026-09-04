def main():
    print("You wake up in a dark and damp basement. Your flashlight has almost dead batteries, but you can still see a staircase going up, and you can see 3 doors marked A, B, and C.")
    print("You can hear a terrible noise upstairs.")
    print("What do you choose?")
    print("A: Open door A")
    print("B: Open door B")
    print("C: Open door C")
    print("T: Go up the stairs")

    choice = input().upper()

    if choice == "A":
        print("You open door A and find a hidden treasure!")
    elif choice == "B":
        print("You open door B and encounter a fierce monster!")
    elif choice == "C":
        print("You open door C and discover a secret passage!")
    elif choice == "T":
        print("You go up the stairs and escape to safety!")
    else:
        print("Invalid choice. Please choose A, B, C, or T.")

if __name__ == "__main__":
    main()
