class TwoFer {
  
  public static twoFer(name :string): string;
  public static twoFer(): string;

  public static twoFer(name?: string): string {
    if(name){
      return 'One for ' + name + ', one for me.'
    }
    else
    {
      return 'One for you, one for me.'
    }
  }
}

export default TwoFer
