create table products
    (id serial not null primary key,
    name varchar(50) not null);

create table categories
    (id serial not null primary key,
    name varchar(50) not null);

create table products_categories
    (id serial not null primary key,
    product_id int not null,
    category_id int null);

alter table products_categories
    add constraint fk_products_categories_to_products
    foreign key(product_id)
    references products(id);

alter table products_categories
    add constraint fk_products_categories_to_categories
    foreign key (category_id)
    references categories(id);

select products.name as ProductName, categories.name as CategoryName
    from products
    left join products_categories on products.id = products_categories.product_id
    left join categories on products_categories.category_id = categories.id;

