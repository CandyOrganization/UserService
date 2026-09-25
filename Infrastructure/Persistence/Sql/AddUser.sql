INSERT INTO users(hashed_password, email, role)
VALUES(@HashedPassword, @Email, @Role)
    RETURNING id as "Id", email as "Email", role as "UserRole", hashed_password as "HashedPassword"
