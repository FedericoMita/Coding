import static org.junit.Assert.*;


import org.junit.Test;

public class CharacterUnitTestCaseTest {
	Character c = new Character("Mario", 10, "It'sa Me, a-Mario");
	
	@Test //Pass
	public void test01() {
		String result = c.getName();
		try {
			assertEquals("Not what was expected", "Mario", result);
		} catch (AssertionError e) {
		System.out.println("Test 01 completed, not equals");
		throw e;
		}
		System.out.println("Test 01 completed, equals");
	}
	
	@Test //Pass
	public void test02() {
		int result = c.getHealth();
		try {
			assertEquals("Not what was expected", 10, result);
		} catch (AssertionError e) {
		System.out.println("Test 02 completed, not equals");
		throw e;
		}
		System.out.println("Test 02 completed, equals");
	}
	
	@Test //Pass
	public void test03() {
		String result = c.getCatchPhrase();
		try {
			assertEquals("Not what was expected", "It'sa Me, a-Mario", result);
		} catch (AssertionError e) {
		System.out.println("Test 03 completed, not equals");
		throw e;
		}
		System.out.println("Test 03 completed, equals");
	}
	
	@Test //Fail
	public void test04() {
		String result = c.getName();
		try {
			assertNull("Name should be NULL", result);
		} catch (AssertionError e) {
		System.out.println("Test 04 completed, not NULL");
		throw e;
		}
		System.out.println("Test 04 completed, NULL");
	}
	
	@Test //Fail
	public void test05() {
		int result = c.getHealth();
		try {
			assertNull("Health should be NULL", result);
		} catch (AssertionError e) {
		System.out.println("Test 05 completed, not NULL");
		throw e;
		}
		System.out.println("Test 05 completed, NULL"); //not sure why dead code only here, possibly because int always true?
		
	}
	
	@Test //Fail
	public void test06() {
		String result = c.getCatchPhrase();
		try {
			assertNull("CatchPhrase should be NULL", result);
		} catch (AssertionError e) {
		System.out.println("Test 06 completed, not NULL");
		throw e;
		}
		System.out.println("Test 06 completed, NULL");
	}

	@Test //Pass
	public void test07() {
		String result = c.getName();
		try {
			assertNotNull("Name should be not NULL", result);
		} catch (AssertionError e) {
		System.out.println("Test 07 completed, NULL");
		throw e;
		}
		System.out.println("Test 07 completed, not NULL");
	}
	
	@Test //Pass
	public void test08() {
		int result = c.getHealth();
		try {
			assertNotNull("Health should be not NULL", result);
		} catch (AssertionError e) {
		System.out.println("Test 08 completed, NULL");
		throw e;
		}
		System.out.println("Test 08 completed, not NULL");
		
	}
	
	@Test //Pass
	public void test09() {
		String result = c.getCatchPhrase();
		try {
			assertNotNull("CatchPhrase should be not NULL", result);
		} catch (AssertionError e) {
		System.out.println("Test 09 completed, NULL");
		throw e;
		}
		System.out.println("Test 09 completed, not NULL");
	}

	@Test //Pass
	public void test10() {
		String result = c.getName();
		try {
			assertTrue("Name should be True", result == "Mario");
		} catch (AssertionError e) {
		System.out.println("Test 10 completed, False");
		throw e;
		}
		System.out.println("Test 10 completed, True");
	}
	
	@Test //Pass
	public void test11() {
		int result = c.getHealth();
		try {
			assertTrue("Health should be True", result == 10);
		} catch (AssertionError e) {
		System.out.println("Test 11 completed, False");
		throw e;
		}
		System.out.println("Test 11 completed, True");
		
	}
	
	@Test //Pass
	public void test12() {
		String result = c.getCatchPhrase();
		try {
			assertTrue("CatchPhrase should be True", result == "It'sa Me, a-Mario");
		} catch (AssertionError e) {
		System.out.println("Test 12 completed, False");
		throw e;
		}
		System.out.println("Test 12 completed, True");

	}
	@Test //Fail
	public void test13() {
		String result = c.getName();
		try {
			assertFalse("Name should be False", result == "Mario");
		} catch (AssertionError e) {
		System.out.println("Test 13 completed, True");
		throw e;
		}
		System.out.println("Test 13 completed, False");
	}
	
	@Test //Fail
	public void test14() {
		int result = c.getHealth();
		try {
			assertFalse("Health should be False", result == 10);
		} catch (AssertionError e) {
		System.out.println("Test 14 completed, True");
		throw e;
		}
		System.out.println("Test 14 completed, False");
		
	}
	
	@Test //Fail
	public void test15() {
		String result = c.getCatchPhrase();
		try {
			assertFalse("CatchPhrase should be False", result == "It'sa Me, a-Mario");
		} catch (AssertionError e) {
		System.out.println("Test 15 completed, True");
		throw e;
		}
		System.out.println("Test 15 completed, False");
	}
	
	@Test //Pass
	public void test16() {
		String result = c.getName();
		try {
			assertSame("Not what was expected", "Mario", result);
		} catch (AssertionError e) {
		System.out.println("Test 16 completed, not same");
		throw e;
		}
		System.out.println("Test 16 completed, same");
	}
	
	@Test //Pass
	public void test17() {
		int result = c.getHealth();
		try {
			assertSame("Not what was expected", 10, result);
		} catch (AssertionError e) {
		System.out.println("Test 17 completed, not same");
		throw e;
		}
		System.out.println("Test 17 completed, same");
	}
	
	@Test //Pass
	public void test18() {
		String result = c.getCatchPhrase();
		try {
			assertSame("Not what was expected", "It'sa Me, a-Mario", result);
		} catch (AssertionError e) {
		System.out.println("Test 18 completed, not same");
		throw e;
		}
		System.out.println("Test 18 completed, same");
	}
	
	@Test //Fail
	public void test19() {
		String result = c.getName();
		try {
			assertNotSame("Not what was expected", "Mario", result);
		} catch (AssertionError e) {
		System.out.println("Test 19 completed, same");
		throw e;
		}
		System.out.println("Test 19 completed, not same");
	}
	
	@Test //Fail
	public void test20() {
		int result = c.getHealth();
		try {
			assertNotSame("Not what was expected", 10, result);
		} catch (AssertionError e) {
		System.out.println("Test 20 completed, same");
		throw e;
		}
		System.out.println("Test 20 completed, not same");
	}
	
	@Test //Fail
	public void test21() {
		String result = c.getCatchPhrase();
		try {
			assertNotSame("Not what was expected", "It'sa Me, a-Mario", result);
		} catch (AssertionError e) {
		System.out.println("Test 21 completed, same");
		throw e;
		}
		System.out.println("Test 21 completed, not same");
	}
	
	//CHAOS
		
		
	@Test //Pass
	public void test22() {
		c.setHealth(10);
		int result = 10;
		try {
			assertEquals("Not what was expected", c.getHealth(), result);
		} catch (AssertionError e) {
		System.out.println("Test 22 completed, not equals");
		throw e;
		}
		System.out.println("Test 22 completed, equals");
	}
	
	@Test //Fail
	public void test23() {
		c.setHealth(10);
		try {
			assertNull("Name should be NULL", c.getHealth());
		} catch (AssertionError e) {
		System.out.println("Test 23 completed, not NULL");
		throw e;
		}
		System.out.println("Test 23 completed, NULL"); //I don't even know
	}
	
	@Test //Pass
	public void test24() {
		c.setHealth(10);
		try {
			assertNotNull("Name should be not NULL", c.getHealth());
		} catch (AssertionError e) {
		System.out.println("Test 24 completed, NULL");
		throw e;
		}
		System.out.println("Test 24 completed, not NULL");
	}
	
	@Test //Pass
	public void test25() {
		c.setHealth(10);
		int result = 10;
		try {
			assertTrue("Name should be True", result == c.getHealth());
		} catch (AssertionError e) {
		System.out.println("Test 25 completed, False");
		throw e;
		}
		System.out.println("Test 25 completed, True");
	}
	
	@Test //Fail
	public void test26() {
		c.setHealth(10);
		int result = 10;
		try {
			assertFalse("Name should be False", result == c.getHealth());
		} catch (AssertionError e) {
		System.out.println("Test 26 completed, True");
		throw e;
		}
		System.out.println("Test 26 completed, False");
	}
	
	
	@Test //Pass
	public void test27() {
		c.setHealth(10);
		int result = 10;
		try {
			assertSame("Not what was expected", c.getHealth(), result);
		} catch (AssertionError e) {
		System.out.println("Test 27 completed, not same");
		throw e;
		}
		System.out.println("Test 27 completed, same");
	}
	

	@Test //Fail
	public void test28() {
		c.setHealth(10);
		int result = 10;
		try {
			assertNotSame("Not what was expected", c.getHealth(), result);
		} catch (AssertionError e) {
		System.out.println("Test 28 completed, same");
		throw e;
		}
		System.out.println("Test 28 completed, not same");
	}
}
	
