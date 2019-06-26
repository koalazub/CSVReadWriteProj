I developed this program as a result of an exam I sat in sometime during March 2019.

The interview was for a junior C#/.NET position. The company was more online data oriented and so the prerequisites were that I had to know some SQL(which I didn't), C# and sorting.

The methods are static as I don't think there should be more than one instance of any of the functions as it might muddle things up. I've created a switch that takes a decision followed by an option to either read or write based on that decision. The reader sifts through all lines present in the .txt file based on a search term the user has inputted. 

The writer asks you for a name and an age. The age is a string which is then parsed into an int before being added to the .txt file. 

The writer will then look through all of the IDs present in the .txt file and then append the newly inputted data at the end along with a newly assigned ID.

I prepared for the last 3, but hadn't learned SQL at all. Although I did do some preparation for dealing with CSV files - as I'd expected them to test me for, I hadn't applied sorting properly. 

This repo is a CSV writer/reader that is able to sift through the ID of a file and append a new set of data as well as read through data based on a search term that is present in the file. 

I create a file within the programs' directory named "koala.txt" and start inputting data there. My aim is to eventually be able to organise the data either by ID, alphabetically through either the first name column or last name column and I have one other thing I want to add, but can't remember at the moment. 

Even though I've already sat for the exam(and failed dismally) I wanted to continue learning about how to manipulate CSV files. After a quick conversation with one of my game developer friends, I've now realised that it is used a lot more often than previously thought. 
