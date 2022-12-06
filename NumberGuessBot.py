import random

def bot_guess(x):
    low = 1
    high = int(x)
    feedback = ""

    try:

        while feedback != "c":
            guess = random.randint(low, high)
            feedback = input(f"\nIs {guess} too high (H), too low (L) or correct (C)?").lower()

            if  feedback == "h":
                high = guess - 1
                continue
            elif feedback == "l":
                low = guess + 1
                continue
            elif feedback == "c":
                break
            else:
                print("Please enter only 'H', 'L' or 'C'!!\n")

        print(f"\nYAAAYY!! I guessed the number {guess}!!!")
    except:
        print("\nDON'T MESS WITH ME!!! (your number doesn't exist!!)\n")
bot_guess(int(input("What number would you like to range?")))