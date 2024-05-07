using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foody_be.Migrations
{
    /// <inheritdoc />
    public partial class initerd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HealthNeedType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthNeedType", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IngredientType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientType", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Nutrition",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    calories = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    fat = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    saturated_fat = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    trans_fat = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    cholesterol = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    carbohydrates = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    fiber = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    sugars = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    protein = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    sodium = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    vitaminD = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    calcium = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    iron = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    potassium = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrition", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RecipeDirection",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    recipeId = table.Column<int>(type: "int", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeDirection", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RecipeIngredient",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    recipeId = table.Column<int>(type: "int", nullable: false),
                    ingredientId = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredient", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    uid = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    weight = table.Column<int>(type: "int", nullable: false),
                    height = table.Column<int>(type: "int", nullable: false),
                    activity = table.Column<int>(type: "int", nullable: false),
                    avatar = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createAt = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.uid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ingredientTypeId = table.Column<int>(type: "int", nullable: false),
                    nutritionId = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isLiquid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ingredientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ingredient_IngredientType_ingredientTypeId",
                        column: x => x.ingredientTypeId,
                        principalTable: "IngredientType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingredient_RecipeIngredient_ingredientId",
                        column: x => x.ingredientId,
                        principalTable: "RecipeIngredient",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Diet",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    userId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    planLenght = table.Column<int>(type: "int", nullable: false),
                    createAt = table.Column<int>(type: "int", nullable: false),
                    isPublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diet", x => x.id);
                    table.ForeignKey(
                        name: "FK_Diet_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HealthNeed",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    userId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    healthNeedTypeId = table.Column<int>(type: "int", nullable: false),
                    caloriesNeedPerDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthNeed", x => x.id);
                    table.ForeignKey(
                        name: "FK_HealthNeed_HealthNeedType_healthNeedTypeId",
                        column: x => x.healthNeedTypeId,
                        principalTable: "HealthNeedType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthNeed_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    userId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    totalTime = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nutritionId = table.Column<int>(type: "int", nullable: false),
                    createAt = table.Column<int>(type: "int", nullable: false),
                    isPublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    recipeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recipe_RecipeDirection_recipeId",
                        column: x => x.recipeId,
                        principalTable: "RecipeDirection",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Recipe_RecipeIngredient_recipeId",
                        column: x => x.recipeId,
                        principalTable: "RecipeIngredient",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Recipe_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dietId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dayPlanLenght = table.Column<int>(type: "int", nullable: false),
                    createAt = table.Column<int>(type: "int", nullable: false),
                    isPublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    nutritionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.id);
                    table.ForeignKey(
                        name: "FK_Plan_Diet_dietId",
                        column: x => x.dietId,
                        principalTable: "Diet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    planId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    body = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createAt = table.Column<int>(type: "int", nullable: false),
                    heart = table.Column<int>(type: "int", nullable: false),
                    clone = table.Column<int>(type: "int", nullable: false),
                    isPublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.id);
                    table.ForeignKey(
                        name: "FK_Blog_Plan_planId",
                        column: x => x.planId,
                        principalTable: "Plan",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blog_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DayPlan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    order = table.Column<int>(type: "int", nullable: false),
                    planId = table.Column<int>(type: "int", nullable: false),
                    mealPlanLenght = table.Column<int>(type: "int", nullable: false),
                    nutritionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayPlan", x => x.id);
                    table.ForeignKey(
                        name: "FK_DayPlan_Nutrition_nutritionId",
                        column: x => x.nutritionId,
                        principalTable: "Nutrition",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayPlan_Plan_planId",
                        column: x => x.planId,
                        principalTable: "Plan",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PlanHistory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    planId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    planValue = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    startDate = table.Column<int>(type: "int", nullable: false),
                    skipDate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createAt = table.Column<int>(type: "int", nullable: false),
                    isChange = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanHistory", x => x.id);
                    table.ForeignKey(
                        name: "FK_PlanHistory_Plan_planId",
                        column: x => x.planId,
                        principalTable: "Plan",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanHistory_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    blogId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    body = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createAt = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comment_Blog_blogId",
                        column: x => x.blogId,
                        principalTable: "Blog",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MealPlan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    order = table.Column<int>(type: "int", nullable: false),
                    dayPlanId = table.Column<int>(type: "int", nullable: false),
                    startTime = table.Column<int>(type: "int", nullable: false),
                    nutritionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlan", x => x.id);
                    table.ForeignKey(
                        name: "FK_MealPlan_DayPlan_dayPlanId",
                        column: x => x.dayPlanId,
                        principalTable: "DayPlan",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealPlan_Nutrition_nutritionId",
                        column: x => x.nutritionId,
                        principalTable: "Nutrition",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FoodForMeal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    mealPlanId = table.Column<int>(type: "int", nullable: false),
                    recipeId = table.Column<int>(type: "int", nullable: false),
                    recipeVulue = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodForMeal", x => x.id);
                    table.ForeignKey(
                        name: "FK_FoodForMeal_MealPlan_mealPlanId",
                        column: x => x.mealPlanId,
                        principalTable: "MealPlan",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodForMeal_Recipe_recipeId",
                        column: x => x.recipeId,
                        principalTable: "Recipe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_planId",
                table: "Blog",
                column: "planId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_userId",
                table: "Blog",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_blogId",
                table: "Comment",
                column: "blogId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_userId",
                table: "Comment",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_DayPlan_nutritionId",
                table: "DayPlan",
                column: "nutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_DayPlan_planId",
                table: "DayPlan",
                column: "planId");

            migrationBuilder.CreateIndex(
                name: "IX_Diet_userId",
                table: "Diet",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodForMeal_mealPlanId",
                table: "FoodForMeal",
                column: "mealPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodForMeal_recipeId",
                table: "FoodForMeal",
                column: "recipeId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthNeed_healthNeedTypeId",
                table: "HealthNeed",
                column: "healthNeedTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthNeed_userId",
                table: "HealthNeed",
                column: "userId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_ingredientId",
                table: "Ingredient",
                column: "ingredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_ingredientTypeId",
                table: "Ingredient",
                column: "ingredientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlan_dayPlanId",
                table: "MealPlan",
                column: "dayPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlan_nutritionId",
                table: "MealPlan",
                column: "nutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_dietId",
                table: "Plan",
                column: "dietId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanHistory_planId",
                table: "PlanHistory",
                column: "planId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanHistory_userId",
                table: "PlanHistory",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_recipeId",
                table: "Recipe",
                column: "recipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_userId",
                table: "Recipe",
                column: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "FoodForMeal");

            migrationBuilder.DropTable(
                name: "HealthNeed");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "PlanHistory");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "MealPlan");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "HealthNeedType");

            migrationBuilder.DropTable(
                name: "IngredientType");

            migrationBuilder.DropTable(
                name: "DayPlan");

            migrationBuilder.DropTable(
                name: "RecipeDirection");

            migrationBuilder.DropTable(
                name: "RecipeIngredient");

            migrationBuilder.DropTable(
                name: "Nutrition");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "Diet");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
