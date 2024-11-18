# Escreva uma função que receba um array de números e retorne o terceiro maior e o terceiro menor elemento desse array.
# Por exemplo, se o array for [1, 2, 3, 4, 5,6,7], a função deve retornar [3,5].

def third_element(array):
  ordered_array = sorted((array))

  third_minor_element = ordered_array[2]
  third_major_element = ordered_array[-3]

  return [third_minor_element, third_major_element]

array = [1, 2, 3, 4, 5, 6, 7]
print(third_element(array))
