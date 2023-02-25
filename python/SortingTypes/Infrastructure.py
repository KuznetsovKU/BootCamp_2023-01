import random


def create_array(size=10, min_value=-10, max_value=10):
    output_array = [random.randint(min_value, max_value) for _ in range(size)]
    return output_array


def make_array_copy(array_to_copy):
    copied_array = [element for element in array_to_copy]
    return copied_array


def make_frequency_dict(input_array):
    frequency_list = []
    max_value = max(input_array)
    min_value = min(input_array)
    if min_value > 0:
        min_value = 0
    size = max_value + 1 - min_value
    for i in range(size):
        frequency_list.append(0)
        for j in range(len(input_array)):
            if input_array[j] == i + min_value:
                frequency_list[i] += 1
    return frequency_list
