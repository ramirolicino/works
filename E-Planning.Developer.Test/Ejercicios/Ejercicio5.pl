use strict;
use warnings;



print "***\nIngresa un numero/operando a la vez. Para obtener el resultado oprima (=) \nPara salir escriba-> salir\nPara continuar escriba-> continuar\n***\n";

my @stack;
while (1)
{
    print "Ingerse: ";
    my $in = <STDIN>;
    chomp $in;
 
    if ($in eq "salir")
    {
        last;
    }
 
    if ($in eq "continuar")
    { 
        pop @stack; 
        next;
    }

    if ($in eq '*') 
    { 
        my $x = pop(@stack);
        my $y = pop(@stack);
        push(@stack, $x*$y);
        next;
    }

    if ($in eq '+') 
    { 
        my $x = pop(@stack);
        my $y = pop(@stack);
        push(@stack, $x + $y);
        next;
    }

    if ($in eq '/')
    {
        my $x = pop(@stack);
        my $y = pop(@stack);
        push(@stack, $y /  $x); 
        next;
    }
    
    if ($in eq '-') 
    { 
        my $x = pop(@stack);
        my $y = pop(@stack);
        push(@stack, $y - $x);
        next;
    }

    if ($in eq '=')
    { 
        print pop(@stack), "\n"; 
        next;
    }

    push @stack, $in;
}   

exit;