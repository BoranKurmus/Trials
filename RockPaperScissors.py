import random

"rock" > "scissors"
"paper" > "rock"
"scissors" > "paper"

player_won = 0
bot_won = 0

while player_won < 3 and bot_won <3:

    rps = ["rock", "paper", "scissors"]
    bot_choice = random.choice(rps)
    player_choice = input("What's your choice? 'R' for ROCK, 'P' for PAPER and 'S' for SCİSSORS.").lower()

    if player_choice in ["r", "p", "s"]:
        if player_choice > bot_choice:
            player_won += 1
            print(f"\nyou won! \t current score = player:{player_won} bot:{bot_won}")
        elif player_choice < bot_choice:
            bot_won += 1
            print(f"\nyou lose! \t current score = player:{player_won} bot:{bot_won}")
        elif player_choice == bot_choice:
            print(f"\nit's a tie!!! \t current score = player:{player_won} bot:{bot_won}")
    else:
        print("\nPlease enter only 'R', 'P' or 'S'!!")
if player_won == 3:
    print("\n   YOU WON THE GAME!!!!")
else:
    print("\n   YOU LOST THE GAME!!!!")