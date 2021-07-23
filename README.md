# NBS-TDP-CSharp-SQL-Project
C Sharp and SQL QA Project for TDP


<b> •	Why are we doing this? : </b> <br>
Developing connections between programming languages and database management tools is important to being able to optimise solutions for data centric requirements. Equally, being able to build simplified user interface screens that do not require user-experience and knowledge of database manipulation languages and can utilise programming languages like C# to convert these inputs into the appropriate form for submission to SQL.

The Sales data example is a good example of this requiring simple user interface to insert new sales into the database and offer a number of pre-determined and preset reporting options with users able to set parametres using interfaces far simpler than the raw code.

<b> •	How I expected the challenge to go : </b> <br>
I expected it to be mostly straightforward with some liklihood for challenge in developing the connections between the C# Code and SQL Database. The design of the C# Console Interface was planned in advance and building it was not expected to provide any challenge. Inserting code to ensure users would not face errors at runtime but would revert to previous screens was also planned in advance with expectation that troubleshooting was likely to be required to ensure accuracy and consistency at the runtime. 

<b>•	What went well? : </b> <br>
The majority of code worked first time with few challenges. The work to build the SQL searches from the C# user inputs went smoothly with some limited initial syntax errors that were quickly resolved. The success in implementing "while (true)" and "try" scripts was above expectations and as a result both requirements were met sooner than had been planned.

The SQL table build was straightforward and no major challenges presented throughout.

<b> •	What didn't go as planned? : </b><br>
Downloading the data from the version of MySQL on my system proved to be challenging and a solution was not determined prior to the submission date. A workaround was found of loading a SQL Script with the code used to build the approximately 600 table records used to test and support the wider build and this file was loaded into the GitHub repository.

<b> •	Possible improvements for future : </b> <br>
Adding input validations through private boolean functions to restrict sales reports to only named products. Allowing for the forms to retain knwoledge of compliant inputs where the exceptions on the trys are triggered. Currently fo instance, entering the wrong data type for price will reset the entry sale input screen and retain no knowledge of previous entries. 
<br> <br>
More widely, making the prices feed automatically through an array pre-loaded into the C# or a second table in the SQL Database. Likewise adding functionality to allow for variations to products across sizing, prices, discounts etc. Finally, most sales are not exclusively one single product so adding functionality to allow a single sale to include multiple different products.
<br><br>
The program is also separated across a number of separate classes to improve readability. In production condensing the number of classes would be preferable.

