# EfCoreMany2ManyBugReproduction

This repo is to reproduce the issue that EF Core's generated migration file would have **unexpected** field in the m2m join table when the **join-table** property is inside **abstract** class.

## Instruction

1. Watch the join table file https://github.com/iWangJiaxiang/EfCoreMany2ManyBugReproduction/blob/3ce4f3dc3f5a930b6845644be63426e0215ed56d/EfCoreMany2ManyBugReproduction/Entities/BookTag.cs#L10

2. Compare with generated migration file https://github.com/iWangJiaxiang/EfCoreMany2ManyBugReproduction/blob/3ce4f3dc3f5a930b6845644be63426e0215ed56d/EfCoreMany2ManyBugReproduction/Migrations/20200818082707_SeeBookTagsTable.cs#L54

3. You will find out an additional expected field `BookBId` was generated, which will cause migration failure (`errno: 150 "Foreign key constraint is incorrectly formed"`) when modify the join table
