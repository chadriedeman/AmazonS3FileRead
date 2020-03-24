# AmazonS3FileRead

## Exercise:

### Language To Use

The following steps should be performed in your preferred programming language. This exercise is solvable in most programming languages, including:

- Python
- C# (both .NET Framework and .NET Core)
- Java
- Node (both TypeScript and JavaScript)
- Go
- Ruby
- Many Others!

### High Level Steps

1. Create a new project/file in your language of choice, named `app`. Open this project/file in an IDE of your choice.

2. Programmatically pull the zip files located in the AWS S3 bucket named `toc-interview-code-assessment-*` into memory. Do not write the files to disk.

3. Extract the zip files programmatically without writing to disk and get their files into a data structure you can manipulate.

4. Print the file contents to your console. Inspect the data and look for a common column that the data can be joined on.

5. Join the files together (based on the data), including columns from both files. The two files you need to join are `MPI_national.csv` and `countries of the world.csv`

6. Print the output of the joined files to your console.

### Extra Steps (If Time Permits)

1. Describe how you would refactor the code you have written to be of enterprise quality. Change the code a bit to demonstrate how you would refactor it.

2. Programmatically create a new S3 bucket named `yourname-interview-dataset` and write out a file to it with the contents of the joined data.
