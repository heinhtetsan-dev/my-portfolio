-- Create database
Create Database hhs_bloomfield_db;

-- Create Customer Tables
Create Table customer (
Customer_ID Varchar(5) Not Null,
Customer_Name Varchar(30) Not Null,
Customer_Address Varchar(100) Not Null,
Customer_Ph Varchar(15) Not Null,
Customer_Email Varchar(30) Not Null,
Primary Key(Customer_ID)
);
Desc customer;

Insert Into Customer (Customer_ID, Customer_Name, Customer_Address, Customer_Ph, Customer_Email)Values
('C0001', 'John Smith', '123 Oxford Street, London, UK', '+447712-345678', 'john.smith@email.com'),
('C0002', 'Hanako Sato', '2-8-1 Nishi-Shinjuku, Shinjuku-ku, Tokyo, Japan', '+8190-1234-5678', 'hanako.sato@example.jp'),
('C0003', 'Emma Johnson', '45 Sunset Blvd, Los Angeles, CA, USA', '+1310-555-2345', 'emma.johnson@email.com'),
('C0004', 'Ichiro Suzuki', '4-5-6 Honmachi, Chuo-ku, Osaka, Japan', '+8170-4567-8912', 'ichiro.suzuki@example.jp'),
('C0005', 'Michael Brown', '200 Queen Street, Toronto, Canada', '+1416-555-1234', 'michael.brown@email.com');

Select * from customer;

-- Create employee Table
Create Table employee (
Employee_ID Varchar (5) Not Null,
Employee_Name Varchar(30) Not Null,
Employee_Address Varchar(100) Not Null,
Employee_Ph Varchar(15) Not Null,
Employee_Email Varchar(30) Not Null,
Employee_Working_Hour Int Not Null,
Employee_Special_Qualification Varchar(80) Not Null,
Employee_Role Varchar(15) Not Null,
Primary Key(Employee_ID)
);
Desc employee;

Insert Into employee (Employee_ID,Employee_Name,Employee_Address,Employee_Ph,Employee_Email,Employee_Working_Hour,Employee_Special_Qualification,Employee_Role)Values
('E0001', 'Olivia Davis', '10 George St, Sydney, Australia', '61498765432', 'olivia.davis@email.com', 36, 'Diploma in Accounting', 'Accountant'),
('E0002', 'William Lee', '88 Orchard Rd, Singapore', '6598765432', 'william.lee@email.com', 40, 'BEng in Electrical Engineering', 'Technician'),
('E0003', 'Sophia Garcia', '9 Greenpark Ave, Dublin, Ireland', '353871234567', 'sophia.garcia@email.com', 37, 'Certified Graphic Designer', 'Designer'),
('E0004', 'James Wilson', '12 Sakura St, Tokyo, Japan', '819012345678', 'james.wilson@email.com', 45, 'MSc in IT Security', 'IT Specialist'),
('E0005', 'Mia Martinez', '25 Avenida del Sol, Madrid, Spain', '34911223344', 'mia.martinez@email.com', 39, 'BA in Marketing', 'Sales Executive');
Select * from employee;



-- Create Inventory Table
Create Table inventory(
Inventory_Code Varchar(5) Not Null,
Inventory_Name Varchar(30) Not Null,
Inventory_Price Decimal(10,2) Not Null,
Inventory_Type Varchar(20) Not Null,
Inventory_Description Varchar(100) Not Null,
Primary Key(Inventory_Code)
);
Desc inventory;


Insert Into inventory Values
('I001', 'Bamboo Watering Can', 22.00, 'Accessories', 'Eco-friendly bamboo watering can with 2L capacity.'),
('I002', 'Cactus Mix', 6.25, 'Plant', 'A variety of mini cactus plants for indoor decoration.'),
('I003', 'Organic Fertilizer 5kg', 18.90, 'Gardening Tool', 'Natural fertilizer blend suitable for all soil types.'),
('I004', 'Ceramic Plant Pot', 9.50, 'Accessories', 'White ceramic pot ideal for small indoor plants.'),
('I005', 'Mini Greenhouse Kit', 35.00, 'Gardening Tool', 'Compact greenhouse kit for seed germination and seedlings.'),
('I006', 'Lavender Seeds Pack', 4.75, 'Plant', 'Premium lavender seeds for outdoor gardens.'),
('I007', 'Soil Moisture Meter', 13.40, 'Accessories', 'Handheld digital meter to check soil moisture levels.'),
('I008', 'Compost Bin', 28.99, 'Gardening Tool', 'Recycled plastic compost bin with ventilation system.'),
('I009', 'Hanging Basket Set', 14.25, 'Accessories', 'Metal hanging baskets with coconut liners.');
Select * from inventory;

Create Table workshop_event(
Workshop_Event_ID Varchar(5) Not Null,
Workshop_Event_Title Varchar(30) Not Null,
Workshop_Event_Date Date Not Null,
Workshop_Event_Time Time Not Null,
Workshop_Event_Place Varchar(100) Not Null,
Workshop_Event_Attendance Varchar(50) Not Null,
Workshop_Event_Equipment Varchar(100) Not Null,
Primary Key(Workshop_Event_ID)
);
Desc workshop_event;

Insert Into workshop_event Values
('W001', 'Organic Gardening Basics', '2025-02-12', '10:00:00', 'Tokyo Midori Green Hall', '25 participants', 'Compost bins, gloves, trowels'),
('W002', 'DIY Herb Garden', '2025-06-19', '13:30:00', 'Osaka Hana Workshop Room', '20 participants', 'Small pots, soil mix, herb seeds'),
('W003', 'Succulent Arrangement Art', '2025-07-26', '11:00:00', 'Kyoto Garden Studio', '18 participants', 'Mini succulents, glass bowls, soil, pebbles'),
('W004', 'Sustainable Composting', '2025-03-02', '09:30:00', 'Sapporo Outdoor Garden Area', '30 participants', 'Compost bins, organic waste samples'),
('W005', 'Family Tree Planting Day', '2025-08-09', '10:00:00', 'Nagoya Community Park Zone', '40 participants', 'Saplings, shovels, watering cans'),
('W006', 'Flower Arrangement Workshop', '2025-09-16', '14:00:00', 'Yokohama Hana Center', '22 participants', 'Fresh flowers, vases, scissors'),
('W007', 'Urban Balcony Gardening', '2025-10-23', '10:30:00', 'Kobe Garden Terrace', '28 participants', 'Planters, soil, fertilizer, seeds'),
('W008', 'Eco-Friendly Pest Control', '2025-11-02', '09:00:00', 'Fukuoka Midori Tent', '26 participants', 'Sprayers, natural oils, sample plants'),
('W009', 'Kids Plant Care Day', '2025-12-09', '10:00:00', 'Sendai Family Green Corner', '35 participants', 'Mini pots, watering cans, coloring sheets');

Select * from workshop_event;

-- Create Sale Table
Create Table sale(
Sale_Code Varchar(10) Not Null,
Sale_Date Date Not Null,
Customer_ID Varchar(5) Not Null,
Employee_ID Varchar(5) Not Null,
Primary Key(Sale_Code)
);
Desc sale;

Insert Into sale (Sale_Code, Sale_Date, Customer_ID, Employee_ID)Values
('S001', '2025-04-12', 'C0001', 'E0003'),
('S002', '2025-04-15', 'C0004', 'E0002'),
('S003', '2025-04-18', 'C0002', 'E0005'),
('S004', '2025-04-21', 'C0003', 'E0001'),
('S005', '2025-04-25', 'C0005', 'E0004'),
('S006', '2025-05-01', 'C0006', 'E0006'),
('S007', '2025-05-04', 'C0008', 'E0007'),
('S008', '2025-05-10', 'C0007', 'E0003'),
('S009', '2025-05-15', 'C0009', 'E0002'),
('S010', '2025-05-20', 'C0010', 'E0005');

Select * from sale;

-- Create Sale_Inventory
Create Table sale_inventory(
Sale_Code Varchar(10) Not Null,
Inventory_Code Varchar(10) Not Null,
Quantity Int Not Null,
Foreign Key(Sale_Code) references Sale(Sale_Code),
Foreign Key(Inventory_Code) references Inventory(Inventory_Code)
);
Desc sale_inventory;

Insert Into sale_inventory (Sale_Code, Inventory_Code, Quantity)Values
('S001', 'I004', 10),  
('S002', 'I006', 30),   
('S003', 'I003', 20),  
('S004', 'I001', 15),
('S005', 'I009', 20),  
('S006', 'I006', 25),  
('S007', 'I002', 17),  
('S008', 'I007', 23),
('S009', 'I003', 21), 
('S010', 'I009', 30);
Select * from sale_inventory;

-- Create Customer_Workshop_Event
Create Table customer_workshop_event(
Customer_ID Varchar(5) Not Null,
Workshop_Event_ID Varchar(5) Not Null,
Foreign Key(Customer_ID) references Customer(Customer_ID),
Foreign Key(Workshop_Event_ID) references Workshop_Event(Workshop_Event_ID)
);
Desc customer_workshop_event;


Insert Into customer_workshop_event (Customer_ID, Workshop_Event_ID)Values
('C0001', 'W001'),  
('C0002', 'W002'),  
('C0003', 'W003'),  
('C0004', 'W004'), 
('C0005', 'W005'),  
('C0002', 'W006'), 
('C0003', 'W007'), 
('C0004', 'W008'),  
('C0001', 'W009');

Select * from customer_workshop_event;


-- Create Employee_Workshop_Event
Create Table employee_workshop_event(
Workshop_Event_ID Varchar(5) Not Null,
Customer_ID Varchar(5) Not Null,
Foreign Key(Workshop_Event_ID) references Workshop_Event(Workshop_Event_ID),
Foreign Key(Customer_ID) references Customer(Customer_ID)
);
Desc employee_workshop_event;

Insert Into employee_workshop_event (Workshop_Event_ID, Customer_ID) Values
('W001', 'C0001'),  
('W002', 'C0002'),  
('W003', 'C0003'),  
('W004', 'C0004'), 
('W005', 'C0005'),  
('W006', 'C0002'), 
('W007', 'C0003'), 
('W008', 'C0004'),  
('W009', 'C0001');
Select * from employee_workshop_event;

-- Create 2 roles
Create Role Sales;
Create Role Admin;
Select * From mysql.roles_mapping;

-- Create two users
Create User 'Olivia Davis'@'localhost' Identified By 'Olivia Davis';
Create User 'James Wilson'@'localhost' Identified By 'James Wilson';


Select User,Host From mysql.user;


-- Two Table to which privileges will be applied 
-- Sale Table
Grant Insert,Update,Delete On sale to sales;
Grant All Privileges on sale to admin;

-- Employee Table
Grant Insert,Update,Delete On employee to sales; 
Grant All Privileges on employee to admin;

Select *
From information_schema.table_privileges
Where table_schema = 'hhs_bloomfield_db';

-- Assign Roles to Users 
Grant 'Sales' TO 'Olivia Davis'@'localhost';
Grant 'Admin' TO 'James Wilson'@'localhost';

-- To confirm roles
Show Grants For 'Olivia Davis'@'localhost';
Show Grants For 'James Wilson'@'localhost';




-- Query queries

Update inventory
Set Inventory_Price = Inventory_Price * 1.10
Where Inventory_Type = 'Gardening Tool';

Select * From inventory
Where Inventory_Type = 'Gardening Tool';




Select 
    Inventory_Name, Inventory_Type, Inventory_Price, Inventory_Description
From 
    inventory
Where 
    (Inventory_Type, Inventory_Price) In (
    Select Inventory_Type, Max(Inventory_Price)
    From inventory
    Where Inventory_Type In ('Plant', 'Gardening Tool', 'Accessories')
Group By
    Inventory_Type
);


Select
    i.Inventory_Type As Category,
    Sum(si.Quantity) As Total_Quantity_Sold,
    Sum(si.Quantity * i.Inventory_Price) As Total_Revenue
From
    sale s
Join 
    sale_inventory si On s.Sale_Code = si.Sale_Code
Join 
    inventory i On si.Inventory_Code = i.Inventory_Code
Where 
    Month(s.Sale_Date) = 4
    And Year(s.Sale_Date) = 2025
GRoup By 
    i.Inventory_Type
Order By 
    Total_Revenue Desc;




Select
    Workshop_Event_Title As Title,
    Workshop_Event_Date As Date,
    Workshop_Event_Time As Time,
    Workshop_Event_Attendance As Participants
From
    workshop_event
Where 
    Workshop_Event_Date > Curdate()
And
    Workshop_Event_Date <= Date_Add(curdate(), Interval 1 month)
Order By
    Workshop_Event_Date ;




Select
    e.Employee_Name, 
    Sum(si.Quantity * i.Inventory_Price) As total_revenue
From
    employee e, 
    sale s, 
    sale_inventory si, 
    inventory i
Where
    e.Employee_ID = s.Employee_ID
    And s.Sale_Code = si.Sale_Code
    And i.Inventory_Code = si.Inventory_Code
    And s.Sale_Date <= '2025-05-01'
Group By 
    e.Employee_ID, e.Employee_Name
Order By
    total_revenue Desc;






