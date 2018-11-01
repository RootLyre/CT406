 
This is the Readme.md for CT 406 HW 7 - Entity Framework.

1. What is the difference between database first and code first approaches?
Database first approach is creating the Database and tables first then write the code to fit and coincide with the existing database. Its more common to do this when you're working with a large amount of data or you don't have a choice because this was an existing database that is assigned to you. 

Code first approach allows you to write the code first and then produce the database and tables from the objects you initialized. If you want to change anything in this, you need to change the data within the code then update the database accordingly. 


2. Explain a scenario were using the Scaffold-DbContext would be beneficial.

It would be beneficial to use Scaffold-DbContext when there is already a database created that uses a model that you would like to use. You can use it to download/import that model to your new application. 

3. What is the difference between configuration by using Data Annotation Attributes vs using Fluent API? 

In a sense, Data Annotations Attributes is a subset of Fluent API. Everything you can do with DAA, you can do with Fluent API. However, just because you can do it with Fluent API doesnt mean you can do it with DAA. Fluent API can: Switch off cascading deletes, specify foren key column nam database when the key isn't exposed in your object model, and fine granular tuning of relationship. Data Annotations Attributes cannot do these. 
