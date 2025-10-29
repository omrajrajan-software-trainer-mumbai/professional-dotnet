// Program to demonstrate the use of user-defined exceptions in C# with Visual Studio
// Programmer: Kavya Krishnan
using System;
using System.IO;
namespace _14_SolicitColdCall
{
    // Class responsible for reading and processing a "cold call" file
    public class ColdCallFileReader : IDisposable
    {
        private FileStream? _fileStream;        // Used to open and read bytes from a file
        private StreamReader? _streamReader;    // Used to read text lines from the file
        private uint _nPeopleToRing;            // Stores how many people need to be called
        private bool _isDisposed = false;       // Tracks if the object has been disposed
        private bool _isOpen = false;           // Tracks if the file has been successfully opened

        // Opens the specified file and reads the first line to determine number of people
        public void Open(string fileName)
        {
            // Prevents reopening after disposal
            if (_isDisposed)
            {
                throw new ObjectDisposedException(nameof(ColdCallFileReader));
            }

            // Opens the file for reading
            _fileStream = new(fileName, FileMode.Open);
            _streamReader = new(_fileStream);

            try
            {
                // Reads the first line, expected to contain the number of people to ring
                string? firstLine = _streamReader.ReadLine();
                if (firstLine != null)
                {
                    // Converts the first line to an unsigned integer
                    _nPeopleToRing = uint.Parse(firstLine);
                    _isOpen = true; // Marks the file as successfully opened
                }
            }
            catch (FormatException ex)
            {
                // Thrown when the first line is not a valid number
                throw new ColdCallFileFormatException($"First line isn't an integer {ex}");
            }
        }

        // Reads and processes each person’s name from the file
        public void ProcessNextPerson()
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException(nameof(ColdCallFileReader));
            }

            // Ensures file is open before reading
            if (!_isOpen)
            {
                throw new UnexpectedException("Attempted to access coldcall file that is not open");
            }

            try
            {
                // Reads the next name line
                string? name = _streamReader?.ReadLine();

                // If no name is found, file format is invalid
                if (name is null)
                {
                    throw new ColdCallFileFormatException("Not enough names");
                }

                // If a name starts with 'B', we consider it a "sales spy" and raise an exception
                if (name[0] is 'B')
                {
                    throw new SalesSpyFoundException(name);
                }

                // Otherwise, print the valid name
                Console.WriteLine(name);
            }
            catch (SalesSpyFoundException ex)
            {
                // Catches and reports if a sales spy is found
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // No special cleanup is done here, but the block ensures finalization if needed
            }
        }

        // Property to return the total number of people to ring
        public uint NPeopleToRing
        {
            get
            {
                if (_isDisposed)
                {
                    throw new ObjectDisposedException(nameof(ColdCallFileReader));
                }

                if (!_isOpen)
                {
                    throw new UnexpectedException("Attempted to access cold–call file that is not open");
                }

                return _nPeopleToRing;
            }
        }

        // Cleans up the object’s resources
        public void Dispose()
        {
            // Prevents double disposal
            if (_isDisposed)
            {
                return;
            }

            _isDisposed = true;
            _isOpen = false;

            // Release resources
            _streamReader?.Dispose();
            _streamReader = null;
        }
    }

    // Custom exception for file format errors (e.g., invalid number or missing data)
    public class ColdCallFileFormatException : Exception
    {
        public ColdCallFileFormatException(string message)
            : base(message) { }

        public ColdCallFileFormatException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    // Custom exception for detecting “sales spies” in the list
    public class SalesSpyFoundException : Exception
    {
        public SalesSpyFoundException(string spyName)
          : base($"Sales spy found, with name {spyName}") { }

        public SalesSpyFoundException(string spyName, Exception innerException)
          : base($"Sales spy found with name {spyName}", innerException) { }
    }

    // Custom exception for unexpected or invalid operations
    public class UnexpectedException : Exception
    {
        public UnexpectedException(string message) : base(message) { }

        public UnexpectedException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    // Main program class that demonstrates reading and handling the file
    internal class Program
    {
        // Method to handle reading and processing the cold call file with exception handling
        static void ColdCallFileReaderLoop1(string fileName)
        {
            ColdCallFileReader peopleToRing = new();

            try
            {
                // Opens the file
                peopleToRing.Open(fileName);

                // Loops through all names specified by the first line
                for (int i = 0; i < peopleToRing.NPeopleToRing; i++)
                {
                    peopleToRing.ProcessNextPerson();
                }

                Console.WriteLine("All callers processed correctly");
            }
            catch (FileNotFoundException)
            {
                // Handles missing file error
                Console.WriteLine($"The file {fileName} does not exist");
            }
            catch (ColdCallFileFormatException ex)
            {
                // Handles file format errors
                Console.WriteLine($"The file {fileName} appears to have been corrupted");
                Console.WriteLine($"Details of problem are: {ex.Message}");

                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception was: {ex.InnerException.Message}");
                }
            }
            catch (Exception ex)
            {
                // Handles any other unexpected errors
                Console.WriteLine($"Exception occurred:\n{ex.Message}");
            }
            finally
            {
                // Ensures resources are cleaned up
                peopleToRing.Dispose();
            }
        }

        // Entry point of the program
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of user-defined exceptions in C# with Visual Studio\n");

            // Ask the user for the input file name
            Console.Write("Please type in the name of the file " +
                          "containing the names of the people to be cold called > ");
            string? fileName = Console.ReadLine();

            // If user entered a valid name, process it
            if (fileName != null)
            {
                ColdCallFileReaderLoop1(fileName);
                Console.WriteLine();

                // Optional second method call for demonstration (commented out)
                //ColdCallFileReaderLoop2(fileName);
                //Console.WriteLine();
            }

            // Pause program before exit
            Console.ReadLine();
        }
    }
}
