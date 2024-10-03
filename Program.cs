// See https://aka.ms/new-console-template for more information


String OldPhonePad(string input) {
  int[] ascii = {32, 38, 65, 68,71,74,77,80,84,87};

  char tmp = '*';
  int count = 0;
  string result = "";

  foreach (char c in input)
  {
      if(c != tmp && tmp != '*'){
        int index = tmp - '0';
        
        result += Char.ConvertFromUtf32(ascii[index]+count-1);
        count = c == ' ' ? 0 : 1;
      }else{
        count++;

        int limit = c == '7' || c == '9' ? 4 : 3;

        if(count > limit){
          count = 1;
        }

        if(c=='0'){
          count = 1;
        }

      }

      if(c != ' '){
        tmp = c;
      }

      if(c=='*'){
        result = result.Remove(result.Length-1);
        count = 0;
      }


      if(c == '#'){
        return result;
      }
  }

  return "??????";
}

string result;

result = OldPhonePad("222 2 22#");
result = OldPhonePad("33#");
result = OldPhonePad("227*#");
result = OldPhonePad("4433555 555666#");
result = OldPhonePad("8 88777444666*664#");

result = OldPhonePad("227*0 0 0227*0227*0227*0227*1 11 111 11117777 77777#");

result = OldPhonePad("77777#");

Console.WriteLine(result);
