https://leetcode.com/problems/roman-to-integer/

int RomanToInt(string s)
{
    int score = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (i + 1 < s.Length)
        {
            var subString = s.Substring(i, 2);

            if (subString == "CM")
            {
                score += 900;
                i++;
                continue;
            }
            else if (subString == "CD")
            {
                score += 400;
                i++;
                continue;
            }
            else if (subString == "XC")
            {
                score += 90;
                i++;
                continue;
            }
            else if (subString == "XL")
            {
                score += 40;
                i++;
                continue;
            }
            else if (subString == "IX")
            {
                score += 9;
                i++;
                continue;
            }
            else if (subString == "IV")
            {
                score += 4;
                i++;
                continue;
            }
        }

        if (s[i] == 'I')
        {
            score += 1;
        }
        else if (s[i] == 'V')
        {
            score += 5;
        }
        else if (s[i] == 'X')
        {
            score += 10;
        }
        else if (s[i] == 'L')
        {
            score += 50;
        }
        else if (s[i] == 'C')
        {
            score += 100;
        }
        else if (s[i] == 'D')
        {
            score += 500;
        }
        else if (s[i] == 'M')
        {
            score += 1000;
        }
        else score += 4444444;
    }

    return score;
}

if (RomanToInt("MCMLXXXIX") != 1989) throw new Exception("Epic fail");
if (RomanToInt("MM") != 2000) throw new Exception("Epic fail");