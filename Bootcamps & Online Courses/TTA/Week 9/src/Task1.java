//let's import some HashMap goodies
import java.util.HashMap;
//this is going to help in sorting through our HashMap
import java.util.TreeMap;
//this is just a self-learning task, no meaning to it
public class Task1 {

	public static void main(String[] args) {
		HashMap<Integer, String> numbers = new HashMap<Integer, String>();
		numbers.put(3, "Three");
		numbers.put(17, "Seventeen");
		numbers.put(5, "Five");
		//let's tried another method, the putIfAbsent, to insert another key and its value into the HashMap
		numbers.putIfAbsent(8, "Eight");
		//now let's see if the same method is going to work when I try to insert an already existent key/value
		numbers.putIfAbsent(5, "Five");
		
		//now let's try using the .containsValue() method while also checking if putIfAbsent worked
		System.out.println("Does the HashMap contains 8 as a key: " + numbers.containsKey(8));
		//let's see the flipped result, for something that isn't in the HashMap and that is a value
		System.out.println("Does the HashMap contains Nine as a value: " + numbers.containsValue("Nine"));
		//now let's print the elements of the HashMap in an unsorted list. Note that it's not printing the keys as FIFO or LIFO, but using the top number as the equivalent bucket 0.
		System.out.println("Unsorted numbers: " + numbers);
		//ok, then sort them in order from smaller to bigger key
		TreeMap<Integer, String> sortedHashMap = new TreeMap<Integer, String>(numbers);
		sortedHashMap.putAll(numbers);
		System.out.println("Sorted numbers: " + sortedHashMap);
		//great, now let's clear all of the HashMap and let's check if it worked in two ways
		numbers.clear();
		//size of HashMap
		System.out.println("How many elements in the HashMap: " + numbers.size());
		//true or false, if the map is empty
		boolean isEmpty = numbers.isEmpty();
		System.out.println("Is the HashMap empty: "+ isEmpty);

	}

}
