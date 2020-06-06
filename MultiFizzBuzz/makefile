CSHARP1 = mcs -out:PartOne.exe
CSHARP2 = mcs -out:PartTwo.exe
MAIN_CLASS = ./PartOne/Program.cs
PARTIAL_CLASSES = ./PartOne/PartOneProgram.cs ./PartOne/Processors/ConditionsProcessor.cs ./PartOne/Conditions/DivideByFive.cs ./PartOne/Conditions/DivideByThree.cs ./API/ICondition.cs
OPT = -optimize+

MAIN_CLASS2 = ./PartTwo/Program.cs
PARTIAL_CLASSES2 = ./PartTwo/PartTwoProgram.cs ./PartOne/Processors/ConditionsProcessor.cs ./PartTwo/Conditions/DivideByFive.cs ./PartTwo/Conditions/DivideBySix.cs ./PartTwo/Conditions/DivideByEleven.cs ./API/ICondition.cs

all: commands program1 program2

commands:	
	sudo apt update
	sudo apt install mono-complete

program1: PartOne
	$(CSHARP1) $(OPT) $(MAIN_CLASS) $(PARTIAL_CLASSES) 

program2: 
	$(CSHARP2) $(OPT) $(MAIN_CLASS2) $(PARTIAL_CLASSES2) 

clean:
	rm *.exe