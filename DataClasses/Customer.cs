using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Clientibus.DataClasses
{
    /// <summary>
    /// Entity Framework Core POCO for customers.
    /// Designed for use with EF Core (DbSet&lt;Customer&gt; in your DbContext).
    /// </summary>
    [Table("Customers")]
    [Index(nameof(Email), IsUnique = true)]
    public class Customer
    {
        /// <summary>
        /// Primary key. Guid is generated client-side to make entity creation easy.
        /// </summary>
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Customer first name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Customer last name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Unique email address used as a business identifier.
        /// </summary>
        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Optional phone number.
        /// </summary>
        [MaxLength(50)]
        public string? Phone { get; set; }

        /// <summary>
        /// Optional postal address.
        /// </summary>
        [MaxLength(500)]
        public string? Address { get; set; }

        /// <summary>
        /// Soft-delete / active flag.
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Created time in UTC.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Last update time in UTC (nullable).
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Concurrency token (rowversion) to enable optimistic concurrency checks.
        /// </summary>
        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}