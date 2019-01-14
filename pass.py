f ='qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890./,;:@#$%^&*()_+-='
pas=''
f= open('pas.txt','a')
for g1 in f :
  pas=g1  
  for g2 in f :
      pas2=pas+g2
      for g3 in f :
          pas3=pas2+g3
          for g4 in f :
              pas4=pas3+g4
              for g5 in f :
                  pas5=pas4+g5
                  for g6 in f :
                      pas6=pas5+g6
                      for g7 in f :
                          pas7=pas6+g7
                          for g8 in f :
                              pas8=pas7+g8
                              print(pas8)
                              f.write( ' = '+str(pas8)+"\n")
                              f.close()
                          
                              
