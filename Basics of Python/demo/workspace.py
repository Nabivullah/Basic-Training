import math
import random
import datetime
import numpy as np
import pandas as pd


# # import methods-> import whole library or part of the library
# # ex: either "import math" or for a specific funtion we can use "From math import sqrt"

# #libraries for data analysis : matplotlib,pyplot,tensorflow,etc

# # vectors: used for parallel computation , textual dat is converted to vectors which is called vectorization
# # if we need to process data in a parallel order instead of a serial order, we use vectore 

# x=np.array([1,2,4])
# y=np.array(([1,2],[4,3]))
# z=np.array((([1,2,3],[1,2,3],[1,2,3])))
# print(z)


# # pandas: used for data manipulation and analysis
# # key tasks: data cleaning,merging,joining,handling missing data,column 
# #            insertion and deletion ,group by operation ,data visualization
# # it has multiple functions to import a specific variable
# # if large data wioth multiple datatype also categorical then we use pandas
# #            else we use numpy mostly for mathematical calculations 


# s=pd.Series([10,20,30,40],name="My numbers")

# print(f"Panda series: \n{s}")
# print(f"Type of series: {type(s)}")

# data={
#     'Name':['alice','bob','charlie','david'],
#     'age':[25,30,35,40],
#     'city':['NYC','London','NYC','NYC']
# }

# df=pd.DataFrame(data)
# print(f"\nPandas DataFrame:\n{df}")


# # CSV files - Comma Seperated Values
# # simple light weight and universally supported for data exchange 
# # read_csv - method in pandas used to import and read data 
# # syntax - df=pd.read_csv("c/.._")

# df=pd.read_csv('ncr_ride_bookings.csv')
# print(df.head())
# print(df.tail)

# Types of data analysis :descriptive analysis of data ,statistical analysis,diagnostics,predictive,
# prescriptive,inferential,EDA-exploratory data analysis 

df=pd.read_csv('datasets.csv')
df_1 = df.drop('datasetName',axis=1)
df=df.rename(columns={"datasetName":"HP","vintage":"cylinders"})
print(df.head())
print(df_1.tail())
# print(df.dtypes)   # prints the data types in each columns 
# print(df.describe()) 

#->Shape- no of rows and columns
# to check null values and other values in the dataset 

duplicate_rows_df= df[df.duplicated()]
print(duplicate_rows_df)

df=df.drop_duplicates()  # used  to drop the duplicates 
df.head(5)

print(df.shape)  

#dropping missing or null values, other method is replacing null columns with median  


print(df.isnull().sum())  # this method is to check how many nulls are there in each column and here ther .sum is to add all the number of NULLS

#dropna method is to drop those elements that have null values present in them 
df_2=df.dropna()
print(df_2)

print(df_2.isnull().sum())


