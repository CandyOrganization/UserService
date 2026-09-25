SELECT
    id as "Id",
    email as "Email",
    role as "UserRole",
    hashed_password as "HashedPassword"
FROM USERS WHERE email=@email