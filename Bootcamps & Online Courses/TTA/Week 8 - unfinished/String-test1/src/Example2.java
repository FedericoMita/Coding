
public class Example2 {

	public static void main(String[] args) {
		String[] wordList = {"Stressed", "Parts", "Straw", "Keep", "Wolf"};
		String reversedList = "";
		for (int i = 0; i < wordList.length; i++) {
		    String word = wordList[i];
		    //word = word.toLowerCase();
		    //word = word.replace(word.substring(0,1), word.substring(0,1).toUpperCase());
		    //wordList[i] = word;
			String reversedWord = "";
		    for (int j = word.length() -1; j >= 0; j--) {
		        reversedWord = reversedWord + word.charAt(j); //StringBuilder might be an easier and quicker solution
		    }
		    reversedList = reversedList + reversedWord + " ";
		}
		System.out.println(reversedList);
}
}
