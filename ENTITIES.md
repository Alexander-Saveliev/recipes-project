# Сущности проекта

## Рецепт

```
recipe
- id
- title
- description
- time
- image
- user_id
```

```
step
- id
- recipe_id
- step_count
- text
```

```
ingridient
- id
- recipe_id
- title
- list
```

```
tags
- id
- recipe_id
- name
```

## Пользователь

```
user
- id
- name
- login
- password
- about
```

```
likes
- id
- recipe_id
- user_id
```

```
favorites
- id
- recipe_id
- user_id
```
