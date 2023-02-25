import random
import Infrastructure as struct


def bubble_sorting(array_to_sort):
    for _ in range(len(array_to_sort)):
        for i in range(len(array_to_sort) - 1):
            if array_to_sort[i] > array_to_sort[i + 1]:
                array_to_sort[i], array_to_sort[i + 1] = array_to_sort[i + 1], array_to_sort[i]
    return array_to_sort


def selection_sorting(array_to_sort):
    for i in range(len(array_to_sort) - 1):
        position = i
        for j in range(i, len(array_to_sort)):
            if array_to_sort[j] < array_to_sort[position]:
                position = j
        array_to_sort[i], array_to_sort[position] = array_to_sort[position], array_to_sort[i]
    return array_to_sort


def quick_sorting(array_to_sort, left_side, right_side):
    left = left_side
    right = right_side
    pivot = array_to_sort[random.randint(left_side, right_side)]
    while left <= right:
        while array_to_sort[left] < pivot:
            left += 1
        while array_to_sort[right] > pivot:
            right -= 1
        if left <= right:
            array_to_sort[left], array_to_sort[right] = array_to_sort[right], array_to_sort[left]
            left += 1
            right -= 1
    if left < right_side:
        quick_sorting(array_to_sort, left, right_side)
    if right > left_side:
        quick_sorting(array_to_sort, left_side, right)
    return array_to_sort


def counting_sort(array_to_sort):
    min_value = min(array_to_sort)
    if min_value > 0:
        min_value = 0
    temp_array = struct.make_frequency_dict(array_to_sort)
    output_array = [0 for _ in range(len(array_to_sort))]
    oa_index = 0
    for i in range(len(temp_array)):
        for j in range(temp_array[i]):
            output_array[oa_index] = i + min_value
            oa_index += 1
    return output_array
