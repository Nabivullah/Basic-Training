import calculator as cal

a=int(input("enter first num "))

b=int(input("enter second num "))

operation=input("enter either sum,div,sub,rem or mul");

if operation=='mul':
    ans=cal.mul(a,b)
    
elif operation=='add':
    ans=cal.add(a,b)
elif operation=='sub':
    ans=cal.sub(a,b)
elif operation=='div':
    ans=cal.div(a,b)
else:
    ans=cal.rem(a,b)

print(ans)