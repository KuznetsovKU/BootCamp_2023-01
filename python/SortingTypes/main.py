import Infrastructure as struct
import Sortings
import time

test_list = struct.create_array()
print(f'Сформированный список: {test_list}')
copy_1 = struct.make_array_copy(test_list)
copy_2 = struct.make_array_copy(test_list)
copy_3 = struct.make_array_copy(test_list)
copy_4 = struct.make_array_copy(test_list)
print(f'Первая копия списка: {copy_1}')
bubble_start = time.perf_counter()
print(f'Результат сортировки "Пузырьком": {Sortings.bubble_sorting(copy_1)}')
bubble_stop = time.perf_counter()
print(f'Скорость сортировки "Пузырьком": {bubble_stop - bubble_start}')
print(f'Вторая копия списка: {copy_2}')
selection_start = time.perf_counter()
print(f'Результат сортировки "Выбором": {Sortings.selection_sorting(copy_2)}')
selection_stop = time.perf_counter()
print(f'Скорость сортировки "Выбором": {selection_stop - selection_start}')
print(f'Третья копия списка: {copy_3}')
quick_start = time.perf_counter()
print(f'Результат Быстрой сортировки: {Sortings.quick_sorting(copy_3, 0, len(copy_3) - 1)}')  # len(copy_3) - 1 -- чтобы не выйти за границы массива
quick_stop = time.perf_counter()
print(f'Скорость Быстрой сортировки: {quick_stop - quick_start}')
print(f'Четвертая копия списка: {copy_4}')
counting_start = time.perf_counter()
print(f'Результат сортировки подсчетом: {Sortings.counting_sort(copy_4)}')
counting_stop = time.perf_counter()
print(f'Скорость сортировки подсчетом: {counting_stop - counting_start}')
