This is the Readme.md for CT 406 HW6 - Security

1. Pick a vulnerability from the OWASP Top Ten (2017 edition is preferable) that we have not discussed in class. Explain it and how to use ASP.NET Core utilities to prevent it.
The ones we discussed in class: SQL Injection, Cross-site scripting, Cross-site Request Forgery.
I choose to discuss A5: Broken Access Control which is when authenticated users have more permissions than they need.  This allows users to access and alter data or files that should have been secured by just using the system as it is coded. ASP.NET Core Utilities can prevent it by controlling which files creating levels of permissions which controls who can view and alter any given data.

2. Explain how passwords are stored in ASP.NET Core and how this relates to the concepts of "Cryptographic Agility".
  Passwords that are to be secure in ASP.NET Core go through a hash which uses a random number generator (RNG) and converts the password into a Base 64 String. This relates to the concept of Cryprographic Agility because it uses the same method to hash/encrypt all of the passwords but there is a variation to the system which allows all of the passwords to remain secure. That variation is the random number generated to affect the encryption so that each password is uniquely hashed. 
  
  
3. The Microsoft.Asp.NetCore.Identity defines the following domain classes. Please explain each:

IdentityRole - This class represents a role that can be connected to a user.

IdentityUserRole - This class represents the connection between a user and a role.

IdentityUserClaim - This class represents a claim that a user possesses, an action the user has taken that requires feedback from the system.

IdentityUserLogin - This class represents a login and the provider for a user. 

IdentityUserToken - This class represents an authentication token for a user. This allows an added layer of security and validation for the user saying who they really are. This is usually associated with an email sent to the email the user provided to prove that they have access to said email.

IdentityRoleClaim - This class represents a claim that is granted to all users within a role. Basically, its a permission allowed to all users of the same rank/level. 
