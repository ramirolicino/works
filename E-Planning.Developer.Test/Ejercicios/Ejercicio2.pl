use strict;
use warnings;


sub ConvertidorDecBin
{
    (my $numDec) = @_;
    chomp($numDec);

    my $numAux;
    my $rta;

    while ($numDec >= 1)
    {
        $numAux = $numDec % 2;      
        $rta = $numAux . $rta;    
        $numDec /= 2;     
    }

    return $rta;
}

sub ConvertidorBinDec
{
    (my $numBin) = @_;
    
    my $numDecimal = 0;
    my $temp = 0;
    my $numAux;

      while ($numBin != 0)  
    {  
        $numAux = $numBin % 10;  
        $numBin = $numBin / 10;  
        $numDecimal = $numDecimal + $numAux * (2 **$temp);
        $temp++;  
    }

    return $numDecimal;  
}



sub Convertidor
{
    my ($num1,$num2,$num3) = @_;

    return ConvertidorBinDec(($num2));
}


my $numero1 = 2;
my $numero2 = "101";
my $numero3 = 10;

print "$numero1, '$numero2', $numero3 => ".Convertidor($numero1 , $numero2, $numero3);







exit;