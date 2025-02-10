# api-study-army

## DISCLAIMER

This is a simple project for learning purpose, and by no means I support any war.

## PROJECT DESCRIPTION

Given that I love videogames, especially military ones, I started getting a basic interest in military matters.
I am just creating a fake military based API in .NET Core 8. I am trying to extend my personal knowledge in programming matters by creating something that has some learning value for me.

### GENERAL STRUCTURE AND DESCRIPTION

It is my intention to follow a Clean Architecture pattern, by separating the application layers by following best practices.

- Each country has its own army.
- Each army has a list of soldiers.
- Each soldier has a grade and specialization, along with an anagraphic section.
- Each army has vehicles (ground - air).
- Each army has equipment.

#### TBD

- Soldiers should have a pay grade.
- In the future it should be possible to assign equipment, weapons, vehicles etc. to units and/or groups, keeping in mind the available quantity.
- In the future armies should be able to buy equipment from vendors (new application).
