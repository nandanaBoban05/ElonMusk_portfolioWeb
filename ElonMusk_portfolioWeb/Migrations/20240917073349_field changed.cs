﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElonMusk_portfolioWeb.Migrations
{
    /// <inheritdoc />
    public partial class fieldchanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dob",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Details");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "Dob",
                table: "Details",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Details",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
