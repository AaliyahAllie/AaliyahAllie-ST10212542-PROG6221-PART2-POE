LINK TO PART 2 GITHUB REPOSITORY: https://github.com/AaliyahAllie/AaliyahAllie-ST10212542-PROG6221-PART2-POE.git

CHANGES TO PART 1:
-Didn't have anything wrong with part 1 so there wasnt anything to change.
-Changed list arrays to generic collections.
-Changed scaling to accomadate for calories.
-Changed reset method to accomadate for calories.
-Added recipe names and calories to recipes.
-Another class created to stored variables that get called.
-Options added to user interface.
-Program makes use of delegates for warning.

How the program runs:
-To run the program press the rebuild solution under the build tab.
-Then run the projects in the run tab.

How users should use the program:
-Program is still a console app.
-Makes use of a numeric menu

Program opens and runs as follows:

-The program will run as follows on start-up:
***********************************************
Welcome To Your Recipe Application
***********************************************
Please enter (1) to launch the menu

-user must enter 1 to launch the menu if they dont it will give a message and redirect:

INVALID OPTION.ENTER (1) TO LAUNCH MENU
***********************************************
Welcome To Your Recipe Application
***********************************************
Please enter (1) to launch the menu

-if they select the correct option it will open the menu:


***********************************************
PLEASE SELECT ONE OF THE NUMERIC OPTIONS BELOW
***********************************************
1.Enter new recipe
2.Display all recipes
3.Display specific recipe
4.Scale specific recipe (0.5, 2, or 3)
5.Reset specific recipe to original values
6.Clear all recipes data
7.Clear a specific recipes data
8.Exit Program
***********************************************

-users have 1 to 8 options to choose from

*Option 1 allows them to enter an unlimted amount of options*
-This is how an interface would run for this option:

Are you sure you want to enter a new recipe? (y/n)
y
***********************************************
ENTER NEW RECIPE DETAILS
***********************************************
Enter the number of recipes you want to enter:
3
Recipe 1:
Enter recipe name:
Tea
Enter number of ingredients:
4
Ingredient 1
Name:
tea
Quantity:
1
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
mg
Enter calorie amount:
10
Available Food Groups:
1. Starchy foods
2. Vegetables and fruits
3. Dry beans, peas, lentils and soya
4. Chicken, fish, meat and eggs
5. Milk and dairy products
6. Fats and oil
7. Water
Enter the number corresponding to the food group this ingredient belongs to:
2
Ingredient 2
Name:
water
Quantity:
1
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
cup
Enter calorie amount:
1
Available Food Groups:
1. Starchy foods
2. Vegetables and fruits
3. Dry beans, peas, lentils and soya
4. Chicken, fish, meat and eggs
5. Milk and dairy products
6. Fats and oil
7. Water
Enter the number corresponding to the food group this ingredient belongs to:
7
Ingredient 3
Name:
milk
Quantity:
1
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
cup
Enter calorie amount:
30
Available Food Groups:
1. Starchy foods
2. Vegetables and fruits
3. Dry beans, peas, lentils and soya
4. Chicken, fish, meat and eggs
5. Milk and dairy products
6. Fats and oil
7. Water
Enter the number corresponding to the food group this ingredient belongs to:
5
Ingredient 4
Name:
sugar
Quantity:
2
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
teaspoon
Enter calorie amount:
30
Available Food Groups:
1. Starchy foods
2. Vegetables and fruits
3. Dry beans, peas, lentils and soya
4. Chicken, fish, meat and eggs
5. Milk and dairy products
6. Fats and oil
7. Water
Enter the number corresponding to the food group this ingredient belongs to:
1
Enter the number of steps:
3
Step 1:
Boil water
Step 2:
add tea and sugar to cup
Step 3:
add water and milk,drink
Recipe Tea successfully saved.

Recipe 2:
Enter recipe name:
Biscuits
Enter number of ingredients:
4
Ingredient 1
Name:
Butter
Quantity:
1
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
cup
Enter calorie amount:
50
Available Food Groups:
1. Starchy foods
2. Vegetables and fruits
3. Dry beans, peas, lentils and soya
4. Chicken, fish, meat and eggs
5. Milk and dairy products
6. Fats and oil
7. Water
Enter the number corresponding to the food group this ingredient belongs to:
6
Ingredient 2
Name:
Flour
Quantity:
2 cup
Invalid input. Please enter a valid number greater than 0.
Ingredient 3
Name:
Milk
Quantity:
1
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
cup
Enter calorie amount:
50
Available Food Groups:
1. Starchy foods
2. Vegetables and fruits
3. Dry beans, peas, lentils and soya
4. Chicken, fish, meat and eggs
5. Milk and dairy products
6. Fats and oil
7. Water
Enter the number corresponding to the food group this ingredient belongs to:
5
Ingredient 4
Name:
djf
Quantity:
1
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
cup
Enter calorie amount:
80
Available Food Groups:
1. Starchy foods
2. Vegetables and fruits
3. Dry beans, peas, lentils and soya
4. Chicken, fish, meat and eggs
5. Milk and dairy products
6. Fats and oil
7. Water
Enter the number corresponding to the food group this ingredient belongs to:
1
Enter the number of steps:
1
Step 1:
1
Recipe Biscuits successfully saved.

Recipe 3:
Enter recipe name:
A
Enter number of ingredients:
1
Ingredient 1
Name:
1
Quantity:
1
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
1
Enter calorie amount:
1
Available Food Groups:
1. Starchy foods
2. Vegetables and fruits
3. Dry beans, peas, lentils and soya
4. Chicken, fish, meat and eggs
5. Milk and dairy products
6. Fats and oil
7. Water
Enter the number corresponding to the food group this ingredient belongs to:
1
Enter the number of steps:
1
Step 1:
1
Recipe A successfully saved.

*Option 2 to display all recipes*
-displays recipes alphabetically


Are you sure you want to display the recipe?(y/n)
y
Now Displaying Recipe
***********************************************
DISPLAYING ALL RECIPE DETAILS:
***********************************************
Recipe Name: A
Ingredients:
1: 1 1 (Food Group: Starchy foods, Calories: 1)
Steps:
Step 1: 1
Total Calories: 1 (Total calories of A are between 0 and 300. This is still in a healthy calorie range.)
***********************************************
Recipe Name: Biscuits
Ingredients:
Butter: 1 cup (Food Group: Fats and oil, Calories: 50)
Milk: 1 cup (Food Group: Milk and dairy products, Calories: 50)
djf: 1 cup (Food Group: Starchy foods, Calories: 80)
Steps:
Step 1: 1
Total Calories: 180 (Total calories of Biscuits are between 0 and 300. This is still in a healthy calorie range.)
***********************************************
Recipe Name: Tea
Ingredients:
tea: 1 mg (Food Group: Vegetables and fruits, Calories: 10)
water: 1 cup (Food Group: Water, Calories: 1)
milk: 1 cup (Food Group: Milk and dairy products, Calories: 30)
sugar: 2 teaspoon (Food Group: Starchy foods, Calories: 30)
Steps:
Step 1: Boil water
Step 2: add tea and sugar to cup
Step 3: add water and milk,drink
Total Calories: 71 (Total calories of Tea are between 0 and 300. This is still in a healthy calorie range.)

*Option 3 display a specific recipe*


Are you sure you want to display a specific recipe?(y/n)
y
Now Displaying Specific Recipe
***********************************************
DISPLAYING SPECIFIC RECIPE:
***********************************************
LIST OF RECIPES:
***********************************************
RecipeName: A
***********************************************
RecipeName: Biscuits
***********************************************
RecipeName: Tea
***********************************************
Enter Name of Recipe To Display:
Tea
Recipe Name: Tea
Ingredients:
tea: 1 mg (Food Group: Vegetables and fruits, Calories: 10)
water: 1 cup (Food Group: Water, Calories: 1)
milk: 1 cup (Food Group: Milk and dairy products, Calories: 30)
sugar: 2 teaspoon (Food Group: Starchy foods, Calories: 30)
Steps:
Step 1: Boil water
Step 2: add tea and sugar to cup
Step 3: add water and milk,drink
Total Calories: 71 (Total calories of Tea are between 0 and 300. This is still in a healthy calorie range.)

*option 4 scale a specific recipe*
Are you sure you want to scale the recipe?(y/n)
y
Now Scaling Recipe
***********************************************
SCALE SPECIFIC RECIPE:
***********************************************
***********************************************
LIST OF RECIPES:
***********************************************
RecipeName: A
***********************************************
RecipeName: Biscuits
***********************************************
RecipeName: Tea
***********************************************
Enter the name of the recipe to scale:
Tea
Enter the scale factor (0.5, 2, or 3):
2
Scaled Recipe:
Recipe Name: Tea
Ingredients:
tea: 2 mg (Food Group: Vegetables and fruits, Calories: 20)
water: 2 cup (Food Group: Water, Calories: 2)
milk: 2 cup (Food Group: Milk and dairy products, Calories: 60)
sugar: 4 teaspoon (Food Group: Starchy foods, Calories: 60)
Steps:
Step 1: Boil water
Step 2: add tea and sugar to cup
Step 3: add water and milk,drink
Total Calories: 142 (Total calories of Tea are between 0 and 300. This is still in a healthy calorie range.)

*option 5 reset*
Are you sure you want to reset recipe?(y/n)
y
Now Reseting Recipe
***********************************************
RESET RECIPE TO ORIGINAL VALUES
***********************************************
***********************************************
LIST OF RECIPES:
***********************************************
RecipeName: A
***********************************************
RecipeName: Biscuits
***********************************************
RecipeName: Tea
***********************************************
Enter the name of the recipe to reset:
Tea
Recipe reset successfully!

Enter Name of Recipe To Display:
Tea
Recipe Name: Tea
Ingredients:
tea: 1 mg (Food Group: Vegetables and fruits, Calories: 10)
water: 1 cup (Food Group: Water, Calories: 1)
milk: 1 cup (Food Group: Milk and dairy products, Calories: 30)
sugar: 2 teaspoon (Food Group: Starchy foods, Calories: 30)
Steps:
Step 1: Boil water
Step 2: add tea and sugar to cup
Step 3: add water and milk,drink
Total Calories: 71 (Total calories of Tea are between 0 and 300. This is still in a healthy calorie range.)

*oPTION 6 TO CLEAR ALL RECIPE*
Are you sure you want to clear all recipes?(y/n)
y
Now Clearing Recipe
***********************************************
CLEAR RECIPE DATA:
***********************************************
ALL RECIPES DATA SUCCESSFULLY CLEARED

***********************************************
Welcome To Your Recipe Application
***********************************************
Please enter (1) to launch the menu

1

***********************************************
PLEASE SELECT ONE OF THE NUMERIC OPTIONS BELOW
***********************************************
1.Enter new recipe
2.Display all recipes
3.Display specific recipe
4.Scale specific recipe (0.5, 2, or 3)
5.Reset specific recipe to original values
6.Clear all recipes data
7.Clear a specific recipes data
8.Exit Program
***********************************************

2

Are you sure you want to display the recipe?(y/n)
y
Now Displaying Recipe
THERE IS NO RECIPE
Returning to main menu
***********************************************
Welcome To Your Recipe Application
***********************************************
Please enter (1) to launch the menu


*OPTION 7 DELETE A RECIPE*
Are you sure you want to clear a recipe's data(y/n)
Y
Now Clearing Recipe
***********************************************
CLEAR SPECIFIC RECIPE DATA:
***********************************************
***********************************************
LIST OF RECIPES:
***********************************************
RecipeName: A
***********************************************
RecipeName: Biscuits
***********************************************
RecipeName: Tea
***********************************************
Enter Name of Recipe To Clear:
A
Recipe cleared successfully!
***********************************************
Welcome To Your Recipe Application
***********************************************
Please enter (1) to launch the menu

1

***********************************************
PLEASE SELECT ONE OF THE NUMERIC OPTIONS BELOW
***********************************************
1.Enter new recipe
2.Display all recipes
3.Display specific recipe
4.Scale specific recipe (0.5, 2, or 3)
5.Reset specific recipe to original values
6.Clear all recipes data
7.Clear a specific recipes data
8.Exit Program
***********************************************

2

Are you sure you want to display the recipe?(y/n)
y
Now Displaying Recipe
***********************************************
DISPLAYING ALL RECIPE DETAILS:
***********************************************
Recipe Name: Biscuits
Ingredients:
Butter: 1 cup (Food Group: Fats and oil, Calories: 50)
Milk: 1 cup (Food Group: Milk and dairy products, Calories: 50)
djf: 1 cup (Food Group: Starchy foods, Calories: 80)
Steps:
Step 1: 1
Total Calories: 180 (Total calories of Biscuits are between 0 and 300. This is still in a healthy calorie range.)
***********************************************
Recipe Name: Tea
Ingredients:
tea: 1 mg (Food Group: Vegetables and fruits, Calories: 10)
water: 1 cup (Food Group: Water, Calories: 1)
milk: 1 cup (Food Group: Milk and dairy products, Calories: 30)
sugar: 2 teaspoon (Food Group: Starchy foods, Calories: 30)
Steps:
Step 1: Boil water
Step 2: add tea and sugar to cup
Step 3: add water and milk,drink
Total Calories: 71 (Total calories of Tea are between 0 and 300. This is still in a healthy calorie range.)

*option 8 to exit*

Are you sure you want to exit? (y/n)
y
THANK YOU FOR USING THIS APPLICATION
PROGRAM WILL NOW CLOSE

C:\Users\Admin\source\repos\AaliyahAllie-ST10212542-PROG6221-PART2-POE\AaliyahAllie-ST10212542-PROG6221-PART2-POE\bin\Debug\net8.0\AaliyahAllie-ST10212542-PROG6221-PART2-POE.exe (process 13524) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .




