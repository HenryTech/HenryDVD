## DVD Database using ASP.NET MVC and Entity Framework Code First

### Objective

This was my final project in The Tech Academy code boot camp. I chose to create a web app using ASP.NET and Entity Framework Code First. To make it more meaningful for me, I developed a means of tracking my DVDs and where they are stored around the house.

My goal was to include the following functionality:

* Create a database of all household DVDs and make it filterable by title, director, writer or location
* Include a separate detail page which will also show featured actors in any title that is selected
* Include CRUD functionality, so titles can be added or deleted and, if a DVD is moved, location can be edited
* Include search functionality, so that DVDs can be searched by title, director, writer or location

### Steps Taken

I created the models first, for both DVDs and Actors (a one-to-many relationship). Then I started on the views, both for all DVDs and a detail view for movies. I then added filtering and search functionality using the ASP.NET framework.

### Results

Having had experience with SQL already I already understood how relational databases work, so creating the models was easy. ASP.NET MVC has many moving parts, though, so getting everything to work together (like filtering and search) was a bit of a challenge, but truly a learning experience! Now I have a way to find a single DVD in my house!

[Return to Profile Homepage](https://github.com/HenryTech/Portfolio)
