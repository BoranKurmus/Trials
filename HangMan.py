################## NOT FINISHED!!! ##############################
name = input("Name:")
print(f"\nWelcome {name}, let's play hangman!") 

def choice_select():
	choice = ""
	print("\nPlease type 'input' for choose a word or 'random' for random word.")
	choice = input("Choice:")
	
	
	while "input" not in choice and "random" not in choice:
		print("Please type 'input' or 'random'.")
		choice = input("Choice:")
		
	return choice

choice = choice_select()

if "input" in choice:

	word = ""
	guessString = ""

	word = input("\n[Choose a word!] \n(please don't use capital letters^^)\n")
	guessString = ""
	lives = 10
	guess = ""

	while lives > 0:

		character_left = 0

		for character in word:

			if character in guessString:
				print(character)

			else:
				print("-")
				character_left += 1

		if character_left == 0:
			print("YOU WON!!!") 
			
			start_again = input("\nDo you want to play again? (y/n)")
			if start_again == "y" :
				choice_select()
			
			elif start_again == "n" :
				print("\nGOODBYE!")
				break
			
			else:
				break
		
					
		
		print(f"you have {lives} life left! \t\tprevious guesses: {list(guessString)}")  
		guess = input("guess a letter:")   
		
		if len(guess) == 1 and guess not in word:
			guessString += guess
			lives -= 1 
		elif len(guess) == 1 and guess in word:
			guessString += guess
		else:
			print("\nplease give just 1 letter.")
	
	if lives == 0:
		print("YOU DİED!!!")
		
		start_again = input("\nDo you want to play again? (y/n)")
		if start_again == "y" :
			choice_select()
		
		elif start_again == "n" :
			print("\nGOODBYE!")
					
	
elif "random" in choice:

	word = ""
	guessString = ""

	import random
	wordList = ["alaska", "atlantis", "metallica", "maneskin", "snowflake", "skateboard", "ocean", "spider", "ironman", "spiderman", "batman", "deaadpool", "phone", "whatsapp", "facebook", "instagram", "youtube", "mirror", "notebook", "python", "unity", "unreal", "imagine", "tower", "hang", "canada", "turkey", "america", "work", "class", "study"]
	word = random.choice(wordList)
	guessString = ""
	lives = 10
	guess = ""

	while lives > 0:

		character_left = 0

		for character in word:

			if character in guessString:
				print(character)

			else:
				print("-")
				character_left += 1

		if character_left == 0:
			print("YOU WON!!!") 

			start_again = input("\nDo you want to play again? (y/n)")
			if start_again == "y" :
				choice_select()
			
			elif start_again == "n" :
				print("\nGOODBYE!")
				break
			
			else:
				break

		
		print(f"you have {lives} life left! \t\tprevious guesses: {list(guessString)}")  
		guess = input("guess a letter:")   
		
		if len(guess) == 1 and guess not in word:
			guessString += guess
			lives -= 1 
		elif len(guess) == 1 and guess in word:
			guessString += guess
		else:
			print("\nplease give just 1 letter.")
	
	if lives == 0:
		print(f"YOU DİED!!! \t Word was: {word}")
		
		start_again = input("\nDo you want to play again? (y/n)")
		if start_again == "y" :
			choice_select()
		
		elif start_again == "n" :
			print("/nGOODBYE!")
				
						

##BORAN KURMUŞ
