### Before

def do_math(x, y)
  condition = x > 10
  add_or_multiply(x, y, condition)
end

def add_or_multiply(x, y, condition)
  return x + y unless condition
  x * y
end

### After

def do_math(x, y)  
  return add(x, y) unless x > 10
  multiply(x, y)
end

def add(x, y)
  x + y
end

def multiply(x, y)
  x * y
end