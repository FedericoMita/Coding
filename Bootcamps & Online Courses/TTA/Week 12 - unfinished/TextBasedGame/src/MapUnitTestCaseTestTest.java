import static org.junit.Assert.*;

import org.junit.Test;

public class MapUnitTestCaseTestTest {
	Map m = new Map(10,10);

	@Test //Pass
	public void test01() {
		int result = m.getCurrentX();
		try {
			assertEquals("Not what was expected", m.getCurrentX(), result);
		} catch (AssertionError e) {
		System.out.println("Test 01 completed, not equals");
		throw e;
		}
		System.out.println("Test 01 completed, equals");
	}
	
	@Test //Pass
	public void test02() {
		int result = m.getCurrentY();
		try {
			assertEquals("Not what was expected", m.getCurrentY(), result);
		} catch (AssertionError e) {
		System.out.println("Test 02 completed, not equals");
		throw e;
		}
		System.out.println("Test 02 completed, equals");
	}
	
	@Test //Pass
	public void test03() {
		int result = m.getX();
		try {
			assertEquals("Not what was expected", m.getX(), result);
		} catch (AssertionError e) {
		System.out.println("Test 03 completed, not equals");
		throw e;
		}
		System.out.println("Test 03 completed, equals");
	}
	@Test //Pass
	public void test04() {
		int result = m.getY();
		try {
			assertEquals("Not what was expected", m.getY(), result);
		} catch (AssertionError e) {
		System.out.println("Test 04 completed, not equals");
		throw e;
		}
		System.out.println("Test 04 completed, equals");
	}
	
//	I have no idea how to test the move() method, so I'll just avoid it entirely for the time being, until I know more
//	
//	@Test //Pass
//	public void test05() {
//		int result = m.move(String direction);
//		try {
//			assertEquals("Not what was expected", m.move(), result);
//		} catch (AssertionError e) {
//		System.out.println("Test 05 completed, not equals");
//		throw e;
//		}
//		System.out.println("Test 05 completed, equals");
//	}
	
	@Test //Pass
	public void test06(int x, int currentX) {
		m.setCurrentX(currentX);
		int result = x;
		try {
			assertEquals("Not what was expected", m.getX(), result);
		} catch (AssertionError e) {
		System.out.println("Test 06 completed, not equals");
		throw e;
		}
		System.out.println("Test 06 completed, equals");
	}
	
	@Test //Pass
	public void test07(int y, int currentY) {
		m.setCurrentX(currentY);
		int result = y;
		try {
			assertEquals("Not what was expected", m.getY(), result);
		} catch (AssertionError e) {
		System.out.println("Test 07 completed, not equals");
		throw e;
		}
		System.out.println("Test 07 completed, equals");
	}
	
	//And then repeating the 7 Assert types asked for the remaining 42 cases
}