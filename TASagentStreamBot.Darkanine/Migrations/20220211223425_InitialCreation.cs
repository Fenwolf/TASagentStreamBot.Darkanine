﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TASagentStreamBot.Darkanine.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomTextCommands",
                columns: table => new
                {
                    CustomTextCommandId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Command = table.Column<string>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomTextCommands", x => x.CustomTextCommandId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TwitchUserName = table.Column<string>(type: "TEXT", nullable: false),
                    TwitchUserId = table.Column<string>(type: "TEXT", nullable: false),
                    FirstSeen = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FirstFollowed = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TTSVoicePreference = table.Column<int>(type: "INTEGER", nullable: false),
                    TTSPitchPreference = table.Column<int>(type: "INTEGER", nullable: false),
                    TTSSpeedPreference = table.Column<int>(type: "INTEGER", nullable: false),
                    TTSEffectsChain = table.Column<string>(type: "TEXT", nullable: true),
                    LastSuccessfulTTS = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AuthorizationLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomTextCommands");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
