-- SQL Script to Create the RestaurantGo Database Schema

CREATE DATABASE RestaurantGo;
USE RestaurantGo;

-- Create Countries Table
CREATE TABLE Countries (
    CountryID INT PRIMARY KEY AUTO_INCREMENT,
    CountryCode INT NOT NULL UNIQUE,
    CountryName VARCHAR(100) NOT NULL
);

-- Create Cities Table
CREATE TABLE Cities (
    CityID INT PRIMARY KEY AUTO_INCREMENT,
    CityName VARCHAR(100) NOT NULL,
    CountryID INT NOT NULL,
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
);

-- Create Locations Table
CREATE TABLE Locations (
    LocationID INT PRIMARY KEY AUTO_INCREMENT,
    Locality VARCHAR(150) NOT NULL,
    Longitude FLOAT NOT NULL,
    Latitude FLOAT NOT NULL,
    CityID INT NOT NULL,
    FOREIGN KEY (CityID) REFERENCES Cities(CityID)
);

-- Create Restaurants Table
CREATE TABLE Restaurants (
    RestaurantID INT PRIMARY KEY,
    RestaurantName VARCHAR(255) NOT NULL,
    LocationID INT NOT NULL,
    PriceRange INT,
    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID)
);

-- Create Cuisines Table
CREATE TABLE Cuisines (
    CuisineID INT PRIMARY KEY AUTO_INCREMENT,
    CuisineType VARCHAR(100) NOT NULL
);

-- Create Ratings Table
CREATE TABLE Ratings (
    RatingID INT PRIMARY KEY AUTO_INCREMENT,
    RestaurantID INT NOT NULL,
    RatingText VARCHAR(50),
    Votes INT,
    FOREIGN KEY (RestaurantID) REFERENCES Restaurants(RestaurantID)
);

-- Create ToDoList Table
CREATE TABLE ToDoList (
    ToDoID INT PRIMARY KEY AUTO_INCREMENT,
    RestaurantID INT NOT NULL,
    RestaurantName VARCHAR(255),
    IsChecked BOOLEAN DEFAULT 0,
    RatingText VARCHAR(50),


    FOREIGN KEY (RestaurantID) REFERENCES Restaurants(RestaurantID),
);