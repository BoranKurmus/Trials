import random

while True:
    choice = input("HEADS or TAILS? (H/T): ")
    flip = random.choice(["HEADS", "TAILS"])
    print("")
    print(flip)
    if choice in ["H", "T"]:
        if choice in flip:
            print("\nYOU WON!")
        else:
            print("\nYOU LOST!")
    else:
        print("Please enter only 'H' or 'T'!")