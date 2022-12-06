def execute():

	def start():
		number1 = int(input("Please type the first number.\n"))
		number2 = int(input("\nPlease type the second number.\n"))
		sign = input("\nPlease choose (+, -, *, /) :::::>" + " ")
	
		if sign == "+":
			print("\n")			
			print(number1 + number2)
			print("\n")

		elif sign == "-":
			print("\n")			
			print(number1 - number2)
			print("\n")

		elif sign == "*":
			print("\n")			
			print(number1 * number2)
			print("\n")

		elif sign == "/":
			print("\n")			
			print(number1 / number2)
			print("\n")

		else:
			print("\n please choose a sign from the list!")
			print("\n")

							
		execute()
	start()		
execute()	
		
	