INSERT INTO users(hashed_password, email, role, employee_id)
VALUES(@HashedPassword, @Email, @Role, @EmployeeId)
    RETURNING id as "Id", email as "Email", role as "UserRole", hashed_password as "HashedPassword", employee_id as "EmployeeId"
