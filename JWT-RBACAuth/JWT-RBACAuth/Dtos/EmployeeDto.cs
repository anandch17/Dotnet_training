namespace JWT_RBACAuth.Dtos
{
    public record EmployeeCreateDto(string Name, string? Position, decimal Salary);
    public record EmployeeUpdateDto(string Name, string? Position, decimal Salary);
}
