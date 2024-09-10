
using DIAssignment;

// Setup dependency injection (using a simple example without a DI container)
UserInputProcessor userIProcessor = new UserInputProcessor();
DataProcessingService pService = new DataProcessingService(userIProcessor);

// Accept user input

Console.Write("Enter data for processing: ");

string userInput = Console.ReadLine();

// Use the data processing service to perform operations and display the result

Console.WriteLine(pService.Run(userInput));