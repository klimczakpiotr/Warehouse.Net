# Warehouse App

This app in ASP.NET manages information about Warehouse:
## Customers
Customers Tab displays list of customers found in Database:

![CustomersList](https://github.com/klimczakpiotr/Warehouse.Net/assets/147413823/5d5ff5e9-484d-4bf6-9c51-bc4201da7eb6)

There is support for pagination and filtratrion (showing Customers that contain a given phrase):

![CustomersSearch](https://github.com/klimczakpiotr/Warehouse.Net/assets/147413823/e546bb55-f8d1-4a4f-9b00-40dda3752040)

Each Customer can be modified, shown details about or removed by the user.

![CustomerDetails](https://github.com/klimczakpiotr/Warehouse.Net/assets/147413823/2571cfbe-79f5-4b0a-93f9-17b66c7da27b)

The app has options to register/login and some functions are only available to logged in users. Adding customer is an example of such an option. It is only displayed on the screen for authorized users.
Moreover, add customer screen has Fluent Validation built-in checking for length of NIP and REGON:

![AddCustomer](https://github.com/klimczakpiotr/Warehouse.Net/assets/147413823/ca3cfbc9-de65-4d75-936e-617af6afede5)

## Items
There is also Items tab, which currently displays list of all items registered in the database. Each item has a 1:1 relation with an Item Type.

![ItemsList](https://github.com/klimczakpiotr/Warehouse.Net/assets/147413823/11a39b4e-0cc3-4cf3-b11f-6f3ebfe6ff94)
