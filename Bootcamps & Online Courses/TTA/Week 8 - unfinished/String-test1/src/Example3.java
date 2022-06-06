
public class Example3 {

//	public static void main(String[] args) {
//		String sentence = "Sixty zippers were quickly picked from the woven jute bag.";
//		Boolean a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z = true;
//		for (int Δ = 0; Δ < sentence.length(); Δ++)
//		{
//			switch(sentence) {
//			case "a":
//				return;
//			case "b":
//				return;
//			case "d":
//				return;
//			case "e":
//				return;
//			case "f":
//				return;
//			case "g":
//				return;
//			case "h":
//				return;
//			case "i":
//				return;
//			case "j":
//				return;
//			case "k":
//				return;
//			case "l":
//				return;
//			case "m":
//				return;
//			case "n":
//				return;
//			case "o":
//				return;
//			case "p":
//				return;
//			case "q":
//				return;
//			case "r":
//				return;
//			case "s":
//				return;
//			case "t":
//				return;
//			case "u":
//				return;
//			case "v":
//				return;
//			case "w":
//				return;
//			case "x":
//				return;
//			case "y":
//				return;
//			case "z":
//				return;
//		}
//			if(true) {
//				System.out.println(sentence + " is a pangram!");
//			}
//				else {
//					System.out.println(sentence + "is not a pangram!");
//			}
//		}
	//THE ABOVE CODE IS JUST A FAILED TEST. It was giving me too much headache, so I research for a better way.
		static int size = 26;
	    static boolean isLetter(char ch)
	    {
	        if (!Character.isLetter(ch))
	            return false;
	        return true;
	    }
	    static boolean allLetter(String str,
	                             int len)
	    {
	        str = str.toLowerCase();
	        boolean[] present = new boolean[size];
	        for (int i = 0; i < len; i++) {
	            if (isLetter(str.charAt(i))) {
	                int letter = str.charAt(i) - 'a';
	                present[letter] = true;
	            }
	        }
	        for (int i = 0; i < size; i++) {
	            if (!present[i])
	                return false;
	        }
	        return true;
	    }
	    public static void main(String args[])
	    {
	        String str = "Sixty zippers were quickly picked from the woven jute bag.";
	        int len = str.length();
	        if (allLetter(str, len))
	            System.out.println("The sentence '" + str + "' is a pangram!");
	        else
	            System.out.println("The sentence '" + str + "' is not a pangram!");
	    }
	}
