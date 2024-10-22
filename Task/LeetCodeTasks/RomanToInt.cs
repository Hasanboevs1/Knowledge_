namespace Task.Tasks;

public class RomanToIntClass
{
    public int RomantToInt(string text) // LX - 60
    {
        var values = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },    // 10 - X
            { 'L', 50 },    // 50 - L
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        int result = 0;
        int perValue = 0;

        for (int i = text.Length - 1; i >= 0; i--) // len: 2-1 = [1, 0][L, X] i = 0; i--;  1, 1>=0, 1-1 = 0 // 0
        {
            int currentValue = values[text[i]]; // L = 50, X = 10;
            if(currentValue < perValue) // 50 < 0 // 10 < 50 ?
                result -= currentValue; // result = 50 - 0 = 50;
            else
                result += currentValue; // result = 50 + 10 = 60;
            
            perValue = currentValue; // perValue = 50; 10;
        }

        return result;
    }
}
