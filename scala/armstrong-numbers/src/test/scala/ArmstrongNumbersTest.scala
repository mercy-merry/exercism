import org.scalatest.{Matchers, FunSuite}

/** @version 1.0.0 */
class ArmstrongNumbersTest extends FunSuite with Matchers {

  test("Single digit numbers are Armstrong numbers") {
    ArmstrongNumbers.isArmstrongNumber(5) should be (true)
  }

  test("There are no 2 digit Armstrong numbers") {
    
    ArmstrongNumbers.isArmstrongNumber(10) should be (false)
  }

  test("Three digit number that is an Armstrong number") {
    
    ArmstrongNumbers.isArmstrongNumber(153) should be (true)
  }

  test("Three digit number that is not an Armstrong number") {
    
    ArmstrongNumbers.isArmstrongNumber(100) should be (false)
  }

  test("Four digit number that is an Armstrong number") {
    
    ArmstrongNumbers.isArmstrongNumber(9474) should be (true)
  }

  test("Four digit number that is not an Armstrong number") {
    
    ArmstrongNumbers.isArmstrongNumber(9475) should be (false)
  }

  test("Seven digit number that is an Armstrong number") {
    
    ArmstrongNumbers.isArmstrongNumber(9926315) should be (true)
  }

  test("Seven digit number that is not an Armstrong number") {
    
    ArmstrongNumbers.isArmstrongNumber(9926314) should be (false)
  }
}